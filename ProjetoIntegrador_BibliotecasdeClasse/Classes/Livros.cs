using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using ProjetoIntegrador_BibliotecasdeClasse;


namespace ProjetoIntegrador_BibliotecasdeClasse
{
    public class Livros
    { 
        public string Codigo { get; set; }

        [Required(ErrorMessage = "ERRO: O Título é um campo OBRIGATÓRIO!")]
        [StringLength(50, ErrorMessage = "ERRO: O Título deve ter no máximo 50 caracteres")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "ERRO: O Autor é um campo OBRIGATÓRIO!")]
        [StringLength(11, ErrorMessage = "ERRO: O Autor deve ter no máximo 11 números")]
        public string Autor { get; set; }

        [Required(ErrorMessage = "ERRO: A Editora é um campo OBRIGATÓRIO!")]
        [StringLength(11, ErrorMessage = "ERRO: A Editora deve ter no máximo 11 números")]
        public string Editora { get; set; }

        [Required(ErrorMessage = "ERRO: O Data de Lançamento é um campo OBRIGATÓRIO!")]
        public string Lancamento { get; set; }

        [Required(ErrorMessage = "ERRO: O Número de Página é um campo OBRIGATÓRIO!")]
        [RegularExpression("([0-9])+", ErrorMessage = "ERRO: O Número de Página só aceita números!")]
        [StringLength(10, ErrorMessage = "ERRO: O Número de Página deve ter no máximo 11 números")]
        public string NumeroPag { get; set; }

        [Required(ErrorMessage = "ERRO: O Idioma é um campo OBRIGATÓRIO!")]
        [StringLength(11, ErrorMessage = "ERRO: O Idioma deve ter no máximo 11 números")]
        public string Idioma { get; set; }
       
        public string Genero { get; set; }

        public string Status { get; set; }

       
       /* Código para validar se todos os dados obrigátorios foram preenchidos e/ou os 
        * requesitos dos dados foram cumpridos.
       */
        public void Validacao()
        {

            var contexto = new ValidationContext(this);
            List<ValidationResult> resultados = new List<ValidationResult>();
            bool EstaValido = Validator.TryValidateObject(this, contexto, resultados, true);
            if (EstaValido == false)
            {
                StringBuilder erros = new StringBuilder();
                foreach (var validacao in resultados)
                {
                    erros.AppendLine(validacao.ErrorMessage);
                }
                throw new ValidationException(erros.ToString());
            }

        }


        #region "Comandos SQL"

        public void Cadastrar()
        {
            try
            {
                string SQL;
                SQL = this.Inserir();
                var bd = new MySQLServerClass();
                bd.SQLCommand(SQL);
                bd.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Erro no Cadastro!:" + e.Message);
            }
        }

        #endregion

        #region "Funções Auxiliares"

        public string Inserir()
        {
            string SQL;

            SQL = @"insert into cadlivro (codlivro,
                    titulo,
                    codautor,
                    codeditora, codidioma, 
                    lancamento, numeropag, statuslivros) 
                    values (";

            SQL += "'" + this.Codigo + "',";
            SQL += "'" + this.Titulo + "',";
            SQL += "'" + this.Autor + "',";
            SQL += "'" + this.Editora + "',";
            SQL += "'" + this.Idioma + "',";
            SQL += "'" + this.Lancamento + "',";
            SQL += "'" + this.NumeroPag + "',";
            SQL += "'" + this.Status + "')";

            return SQL;

        }


       
       
        #endregion
    }
}
