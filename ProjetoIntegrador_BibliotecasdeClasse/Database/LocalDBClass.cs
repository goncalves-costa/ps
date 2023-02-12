using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ProjetoIntegrador_BibliotecasdeClasse.Database
{
    public class LocalDBClass
    {
        public string stringConn;

        public SqlConnection conDB;

        public LocalDBClass(){
            try
            {
                stringConn = "";
                conDB = new SqlConnection(stringConn);
                conDB.Open();
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
           
        
        }

        public DataTable SQLQuery(string SQL)
        {
            DataTable dt = new DataTable();
            try
            {
                var myComand = new SqlCommand(SQL, conDB);
                myComand.CommandTimeout = 0;
                var myReader = myComand.ExecuteReader();
                dt.Load(myReader);
                
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return dt;
        }

        public string SQLCommand(string SQL)
        {
            try
            {
                var myComand = new SqlCommand(SQL, conDB);
                myComand.CommandTimeout = 0;
                var myReader = myComand.ExecuteReader();
                return "";
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        
        public void Close()
        {
            conDB.Close();
        }


    }
}
