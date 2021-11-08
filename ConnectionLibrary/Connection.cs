using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Security.Cryptography;

namespace ConnectionLibrary
{

    public abstract class Connection
    {
        SqlConnection conn;
        SqlDataAdapter adapter;
        string cnx;
        SqlCommandBuilder cmdbuilder;



        public Connection()
        {
            getConnectionString();
        }
        private void getConnectionString()
        {
            ConnectionStringSettings conf = ConfigurationManager.ConnectionStrings["STARPDO"];
            if (conf != null) cnx = conf.ConnectionString;
        }


        public void Conectar()
        {
            conn = new SqlConnection(cnx);
            conn.Open();

        }
        public DataSet PortarTaula(DataSet dts, string nomtaula)
        {
            string query = "select * from " + nomtaula;

            adapter = new SqlDataAdapter(query, conn);
            dts = new DataSet();
            adapter.Fill(dts, nomtaula);
            conn.Close();
            return dts;

        }
        public DataSet PortarPerConsulta(string query, DataSet dts)
        {
            adapter = new SqlDataAdapter(query, conn);
            dts = new DataSet();
            adapter.Fill(dts, "STARPDO");
            conn.Close();
            return dts;
        }
        public DataSet PortarPerConsulta(string query, DataSet dts, string nomDataTable)
        {
            adapter = new SqlDataAdapter(query, conn);
            dts = new DataSet();
            adapter.Fill(dts, nomDataTable);
            conn.Close();
            return dts;
        }
        public int Actualitzar(DataSet dts, string query, string taula)
        {
            int result = 0;
            Conectar();
            adapter = new SqlDataAdapter(query, conn);
            cmdbuilder = new SqlCommandBuilder(adapter);

            if (dts.HasChanges())
            {
                result = Executa(result, dts, adapter);
            }
            conn.Close();

            return result;
        }
        private int Executa(int result, DataSet dts, SqlDataAdapter adapter)
        {
            result = adapter.Update(dts.Tables[0]);

            return result;
        }

        public DataSet Val(DataSet dts, string user, string pass)
        {
            SqlDataAdapter dta = new SqlDataAdapter();

            bool correcte = false;
            dts = new DataSet();

            Conectar();

            SqlCommand command = conn.CreateCommand();

            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM [Users] " +
                                  "WHERE [Login] = @User ";
            // "AND [Password] = @Pass";

            command.Parameters.Add(new SqlParameter("@User", user));
            //command.Parameters.Add(new SqlParameter("@Pass", pass));
            command.ExecuteNonQuery();

            dta.SelectCommand = command;
            dta.Fill(dts);

            conn.Close();

            //if (dts.Tables[0].Columns["Password"].Equals(pass))
            //{
            //    correcte = true;
            //}


            //correcte = VerifyPassword(pass, passwordSalt, passwordHash);
            /*
            if (dts.Tables[0].Rows.Count > 0)
            {
                correcte = true;
            }
            */

            return dts;
        }



    }
}
