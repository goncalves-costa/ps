using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegrador_BibliotecasdeClasse
{
    public class Emprestimo
    {

        public string Codigo { get; set; }

        [Required]
        public string Leitor { get; set; }

        [Required]
        public string FuncionarioEmprestimo { get; set; }

        [Required]
        public string DataEmprestimo { get; set; }

        [Required]
        public string PrazoDevolucao { get; set; }

        public string FuncionarioDevolucao { get; set; }
        public string DataDevolucao { get; set; }

        public string multa;


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
        #endregion

        #region "Funções Complementares"

        public string Inserir()
        {
            string SQL;

            SQL = @"insert into emprestimo (codemprestimo, codleitor, codfunc_emprestimo, 
                    data_emprestimo, prazo_devolucao)
                    values (";

            SQL += "'" + this.Codigo + "',";
            SQL += "'" + this.Leitor + "',";
            SQL += "'" + this.FuncionarioEmprestimo + "',";
            SQL += "'" + this.DataEmprestimo + "',";
            SQL += "'" + this.PrazoDevolucao + "')";


            return SQL;
        }
        #endregion
    }
}
