using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Web;


namespace ConnectionLibrary
{
    public abstract class Connection
    {
        SqlConnection conn;
        SqlDataAdapter adapter;
        string cnx;
        DataSet dts;
        
        public Connection()
        {
            GetConnectionString();
        }

        private void GetConnectionString()
        {
            ConnectionStringSettings conf = ConfigurationManager.ConnectionStrings["STARPDO"];
            if (conf != null) cnx = conf.ConnectionString;
        }

        public void Conectar()
        {
            conn = new SqlConnection(cnx);
            conn.Open();
        }

        public DataSet PortarTaula(string nomtaula)
        {
            string query = "SELECT * FROM " + nomtaula;

            adapter = new SqlDataAdapter(query, conn);
            dts = new DataSet();
            adapter.Fill(dts, nomtaula);

            conn.Close();
            return dts;
        }

        public DataSet PortarPerConsulta(string query)
        {
            adapter = new SqlDataAdapter(query, conn);
            dts = new DataSet();
            adapter.Fill(dts, "STARPDO");

            conn.Close();
            return dts;
        }

        public DataSet PortarPerConsulta(string query, string nomDataTable)
        {
            adapter = new SqlDataAdapter(query, conn);
            dts = new DataSet();
            adapter.Fill(dts, nomDataTable);

            conn.Close();
            return dts;
        }

        public int Actualitzar(DataSet dts, string query)
        {
            
            int result = 0;
            Conectar();
            adapter = new SqlDataAdapter(query, conn);
            #pragma warning disable IDE0059 // Asignación innecesaria de un valor
            SqlCommandBuilder cmdbuilder = new SqlCommandBuilder(adapter);
            #pragma warning restore IDE0059 // Asignación innecesaria de un valor
            
            if (dts.HasChanges())
            {
                result = adapter.Update(dts.Tables[0]);
            }

            conn.Close();
            return result;
        }

        public int Executa(string query)
        {
            Conectar();
            SqlCommand cmd = new SqlCommand(query, conn);
            int registresAfectats = cmd.ExecuteNonQuery();
            return registresAfectats;
        }

        public DataSet IsUser(string user)
        {
            SqlDataAdapter dta = new SqlDataAdapter();
            dts = new DataSet();

            Conectar();

            SqlCommand command = conn.CreateCommand();

            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM [Users] " +
                                  "WHERE [Login] = @User ";

            command.Parameters.Add(new SqlParameter("@User", user));

            command.ExecuteNonQuery();

            dta.SelectCommand = command;
            dta.Fill(dts);
            conn.Close();
            return dts;
        }
    }
}
