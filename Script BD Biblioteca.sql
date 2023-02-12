-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema biblioteca
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema biblioteca
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `biblioteca` DEFAULT CHARACTER SET utf8 ;
USE `biblioteca` ;

-- -----------------------------------------------------
-- Table `biblioteca`.`autor`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `biblioteca`.`autor` (
  `codautor` INT(11) NOT NULL AUTO_INCREMENT,
  `nomeautor` VARCHAR(50) NOT NULL,
  PRIMARY KEY (`codautor`))
ENGINE = InnoDB
AUTO_INCREMENT = 9
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `biblioteca`.`cadfunc`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `biblioteca`.`cadfunc` (
  `codfunc` INT(11) NOT NULL AUTO_INCREMENT,
  `nomefunc` VARCHAR(50) NOT NULL,
  `cpf` VARCHAR(11) NOT NULL,
  `datanasc` DATE NOT NULL,
  `email` VARCHAR(50) NOT NULL,
  `telefone` VARCHAR(15) NOT NULL,
  `cep` VARCHAR(8) NOT NULL,
  `cidade` VARCHAR(30) NOT NULL,
  `estado` VARCHAR(2) NOT NULL,
  `rua` VARCHAR(50) NOT NULL,
  `bairro` VARCHAR(30) NOT NULL,
  `numero` VARCHAR(10) NOT NULL,
  `senha` VARCHAR(15) NOT NULL,
  PRIMARY KEY (`codfunc`))
ENGINE = InnoDB
AUTO_INCREMENT = 9
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `biblioteca`.`cadleitor`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `biblioteca`.`cadleitor` (
  `codleitor` INT(11) NOT NULL AUTO_INCREMENT,
  `nomeleitor` VARCHAR(50) NOT NULL,
  `cpf` VARCHAR(11) NOT NULL,
  `datanasc` DATE NOT NULL,
  `email` VARCHAR(50) NOT NULL,
  `telefone` VARCHAR(15) NOT NULL,
  `cep` VARCHAR(8) NOT NULL,
  `cidade` VARCHAR(30) NOT NULL,
  `estado` VARCHAR(2) NOT NULL,
  `rua` VARCHAR(50) NOT NULL,
  `bairro` VARCHAR(30) NOT NULL,
  `numero` VARCHAR(10) NOT NULL,
  PRIMARY KEY (`codleitor`))
ENGINE = InnoDB
AUTO_INCREMENT = 9
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `biblioteca`.`editora`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `biblioteca`.`editora` (
  `codeditora` INT(11) NOT NULL AUTO_INCREMENT,
  `nomeeditora` VARCHAR(50) NOT NULL,
  `cnpjeditora` VARCHAR(14) NOT NULL,
  `cidadeeditora` VARCHAR(30) NOT NULL,
  `estadoeditora` VARCHAR(2) NOT NULL,
  PRIMARY KEY (`codeditora`))
ENGINE = InnoDB
AUTO_INCREMENT = 8
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `biblioteca`.`idiomaoriginal`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `biblioteca`.`idiomaoriginal` (
  `codidioma` INT(11) NOT NULL AUTO_INCREMENT,
  `nomeidioma` VARCHAR(30) NOT NULL,
  PRIMARY KEY (`codidioma`))
ENGINE = InnoDB
AUTO_INCREMENT = 10
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `biblioteca`.`cadlivro`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `biblioteca`.`cadlivro` (
  `codlivro` INT(11) NOT NULL AUTO_INCREMENT,
  `titulo` VARCHAR(100) NOT NULL,
  `codautor` INT(11) NOT NULL,
  `codeditora` INT(11) NOT NULL,
  `codidioma` INT(11) NOT NULL,
  `lancamento` DATE NOT NULL,
  `numeropag` VARCHAR(6) NULL DEFAULT NULL,
  `statuslivros` VARCHAR(2) NULL DEFAULT NULL,
  PRIMARY KEY (`codlivro`),
  INDEX `codeditora` (`codeditora` ASC) VISIBLE,
  INDEX `codidioma` (`codidioma` ASC) VISIBLE,
  INDEX `codautor` (`codautor` ASC) VISIBLE,
  CONSTRAINT `cadlivro_ibfk_3`
    FOREIGN KEY (`codeditora`)
    REFERENCES `biblioteca`.`editora` (`codeditora`),
  CONSTRAINT `cadlivro_ibfk_4`
    FOREIGN KEY (`codidioma`)
    REFERENCES `biblioteca`.`idiomaoriginal` (`codidioma`),
  CONSTRAINT `cadlivro_ibfk_5`
    FOREIGN KEY (`codautor`)
    REFERENCES `biblioteca`.`autor` (`codautor`))
ENGINE = InnoDB
AUTO_INCREMENT = 12
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `biblioteca`.`emprestimo`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `biblioteca`.`emprestimo` (
  `codemprestimo` INT(11) NOT NULL AUTO_INCREMENT,
  `codleitor` INT(11) NOT NULL,
  `codfunc_emprestimo` INT(11) NOT NULL,
  `data_emprestimo` DATE NOT NULL,
  `prazo_devolucao` DATE NOT NULL,
  `codfunc_devolucao` INT(11) NULL DEFAULT NULL,
  `data_devolucao` DATE NULL DEFAULT NULL,
  `multa` DECIMAL(5,2) NULL DEFAULT 0.00,
  PRIMARY KEY (`codemprestimo`),
  INDEX `codleitor` (`codleitor` ASC) VISIBLE,
  INDEX `codfuncsaida` (`codfunc_emprestimo` ASC) VISIBLE,
  INDEX `codfuncdevolucao` (`codfunc_devolucao` ASC) VISIBLE,
  CONSTRAINT `emprestimo_ibfk_2`
    FOREIGN KEY (`codleitor`)
    REFERENCES `biblioteca`.`cadleitor` (`codleitor`),
  CONSTRAINT `emprestimo_ibfk_3`
    FOREIGN KEY (`codfunc_emprestimo`)
    REFERENCES `biblioteca`.`cadfunc` (`codfunc`),
  CONSTRAINT `emprestimo_ibfk_4`
    FOREIGN KEY (`codfunc_devolucao`)
    REFERENCES `biblioteca`.`cadfunc` (`codfunc`))
ENGINE = InnoDB
AUTO_INCREMENT = 9
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `biblioteca`.`emprestimolivro`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `biblioteca`.`emprestimolivro` (
  `codemprestimo` INT(11) NOT NULL,
  `codlivro` INT(11) NOT NULL,
  INDEX `codemprestimo` (`codemprestimo` ASC) VISIBLE,
  INDEX `codlivro` (`codlivro` ASC) VISIBLE,
  CONSTRAINT `emprestimolivro_ibfk_1`
    FOREIGN KEY (`codemprestimo`)
    REFERENCES `biblioteca`.`emprestimo` (`codemprestimo`),
  CONSTRAINT `emprestimolivro_ibfk_2`
    FOREIGN KEY (`codlivro`)
    REFERENCES `biblioteca`.`cadlivro` (`codlivro`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `biblioteca`.`genero`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `biblioteca`.`genero` (
  `codgenero` INT(11) NOT NULL AUTO_INCREMENT,
  `nomegenero` VARCHAR(30) NOT NULL,
  PRIMARY KEY (`codgenero`))
ENGINE = InnoDB
AUTO_INCREMENT = 10
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `biblioteca`.`generolivro`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `biblioteca`.`generolivro` (
  `codgenero` INT(11) NOT NULL,
  `codlivro` INT(11) NOT NULL,
  INDEX `codgenero` (`codgenero` ASC) VISIBLE,
  INDEX `codlivro` (`codlivro` ASC) VISIBLE,
  CONSTRAINT `generolivro_ibfk_1`
    FOREIGN KEY (`codgenero`)
    REFERENCES `biblioteca`.`genero` (`codgenero`),
  CONSTRAINT `generolivro_ibfk_2`
    FOREIGN KEY (`codlivro`)
    REFERENCES `biblioteca`.`cadlivro` (`codlivro`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;


insert into cadfunc (
				nomefunc, 
                 cpf, datanasc, 
                 email, telefone, 
                 cep, cidade, estado,
                 rua, bairro, numero, senha) 
                 values ("adm", "123456891", '1999.01.01',"adm","1345-4566","134555", "AAA","SP", "adm", "adm", "00", "123");