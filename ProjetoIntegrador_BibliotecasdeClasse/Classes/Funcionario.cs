using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegrador_BibliotecasdeClasse
{
    public class Funcionario
    {

        public string Codigo { get; set; }

        [Required(ErrorMessage = "ERRO: O Nome é um campo OBRIGATÓRIO!")]
        [StringLength(50, ErrorMessage = "ERRO: O Nome deve ter no máximo 50 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "ERRO: O CPF é um campo OBRIGATÓRIO!")]
        [RegularExpression("([0-9])+", ErrorMessage = "ERRO: O Campo CPF só aceita números!")]
        [StringLength(11, ErrorMessage = "ERRO: O CPF deve ter no máximo 11 números")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "ERRO: O Código é um campo OBRIGATÓRIO!")]
        public string DataNasc { get; set; }

        [Required(ErrorMessage = "ERRO: O Email é um campo OBRIGATÓRIO!")]      
        public string Email { get; set; }

        [Required(ErrorMessage = "ERRO: O Telefone é um campo OBRIGATÓRIO!")]
        [RegularExpression("([0-9])+", ErrorMessage = "ERRO: O Telefone só aceita números!")]
        [StringLength(15, ErrorMessage = "ERRO: O Telefone deve ter no máximo 15 números")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "ERRO: O CEP é um campo OBRIGATÓRIO!")]
        [RegularExpression("([0-9])+", ErrorMessage = "ERRO: O Campo CEP só aceita números!")]
        [StringLength(8, ErrorMessage = "ERRO: O CEP deve ter no máximo 8 números")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "ERRO: O Estado é um campo OBRIGATÓRIO!")]
        [StringLength(2, ErrorMessage = "ERRO: O Estado deve ter no máximo 2 números")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "ERRO: O Cidade é um campo OBRIGATÓRIO!")]
        [StringLength(30, ErrorMessage = "ERRO: O Cidade deve ter no máximo 11 números")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "ERRO: O Bairro é um campo OBRIGATÓRIO!")]
        [StringLength(30, ErrorMessage = "ERRO: O Bairro deve ter no máximo 30 caracteres")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "ERRO: O Bairro é um campo OBRIGATÓRIO!")]
        public string Rua { get; set; }

        [Required(ErrorMessage = "ERRO: O Número é um campo OBRIGATÓRIO!")]
        [RegularExpression("([0-9])+", ErrorMessage = "ERRO: O Campo Código só aceita números!")]
        [StringLength(10, ErrorMessage = "ERRO: O Número deve ter no máximo 20 números")]
        public string Numero { get; set; }

        
        public string Senha { get; set; }


        public void ValidaComplemento()
        {
            bool validaCpf = Uteis.Valida(this.Cpf);
            if (validaCpf == false)
            {
                throw new Exception("Cpf Invalido");
            }
        }

        
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

        #region "Funções SQL"

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

        

        public List<List<string>> ListarTodos()
        {
            List<List<string>> ListaBusca = new List<List<string>>();
            try
            {
                var SQL = "select * from cadfunc";
                var bd = new MySQLServerClass();
                var dt = bd.SQLQuery(SQL);

                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    ListaBusca.Add(new List<string> { dt.Rows[i]["codfunc"].ToString(),
                        dt.Rows[i]["nomefunc"].ToString()});
                }

                return ListaBusca;

            }
            catch (Exception ex)
            {
                throw new Exception("ERRO na listagem dos funcionários: " + ex.Message);
            }

        }

        public void Atualizar()
        {
            try
            {
                string SQL;
                SQL = this.Update();
                var bd = new MySQLServerClass();
                bd.SQLCommand(SQL);
                bd.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Erro na Atualização!:" + e.Message);
            }
        }

        public void Excluir(string codigo)
        {
            try
            {
                string SQL;
                SQL = $"drop * from cadfunc where codfunc = {codigo}";
                var bd = new MySQLServerClass();
                bd.SQLCommand(SQL);
                bd.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Erro na Exclusão!:" + e.Message);
            }
        }



        #endregion

        #region"Funções Auxiliares"

        public string Inserir()
        {
            string SQL;

            SQL = @"insert into cadfunc (
                 nomefunc, 
                 cpf, datanasc, 
                 email, telefone, 
                 cep, cidade, estado,
                 rua, bairro, numero, senha) 
                 values (";

            SQL += "'" + this.Nome + "',";
            SQL += "'" + this.Cpf + "',";
            SQL += "'" + this.DataNasc + "',";
            SQL += "'" + this.Email + "',";
            SQL += "'" + this.Telefone + "',";
            SQL += "'" + this.Cep + "',";
            SQL += "'" + this.Cidade + "',";
            SQL += "'" + this.Estado + "',";
            SQL += "'" + this.Rua + "',";
            SQL += "'" + Bairro + "',";
            SQL += "'" + this.Numero + "',";
            SQL += "'" + this.Senha + "')";

            return SQL;
        }

        public string Update()
        {
            string SQL;

            SQL = @"update cadfunc set ";
            SQL += "nomefunc = '" + this.Nome + "',";
            SQL += "cpf = '" + this.Cpf + "',";
            SQL += "datanasc = '" + this.DataNasc + "',";
            SQL += "email = '" + this.Email + "',";
            SQL += "telefone = '" + this.Telefone + "',";
            SQL += "cep = '" + this.Cep + "',";
            SQL += "cidade = '" + this.Cidade + "',";
            SQL += "estado = '" + this.Estado + "',";
            SQL += "rua = '" + this.Rua + "',";
            SQL += "bairro = '" + this.Bairro + "',";
            SQL += "numero = '" + this.Numero + "', ";
            SQL += "senha = '" + this.Senha + "'";
            SQL += "where codfunc = '" + this.Codigo + "';";

            return SQL;
        }


        public Funcionario DataRowFuncionario(DataTable dt)
        {
            Funcionario l = new Funcionario();

            l.Codigo = dt.Rows[0]["codfunc"].ToString();
            l.Nome = dt.Rows[0]["nomefunc"].ToString();
            l.Cpf = dt.Rows[0]["cpf"].ToString();
            l.DataNasc = dt.Rows[0]["datanasc"].ToString();
            l.Email = dt.Rows[0]["email"].ToString();
            l.Telefone = dt.Rows[0]["telefone"].ToString();
            l.Cep = dt.Rows[0]["cep"].ToString();
            l.Estado = dt.Rows[0]["estado"].ToString();
            l.Cidade = dt.Rows[0]["cidade"].ToString();
            l.Bairro = dt.Rows[0]["bairro"].ToString();
            l.Rua = dt.Rows[0]["rua"].ToString();
            l.Numero = dt.Rows[0]["numero"].ToString();
            l.Senha = dt.Rows[0]["senha"].ToString();

            return l;
        }

        #endregion
    }
}
