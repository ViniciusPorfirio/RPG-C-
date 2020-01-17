using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;


namespace RPG_forms.DAOs.ClassBase
{
    public class DAOclassBase : ClassAdd
    {
        static string connString = "User=root;server=localhost;Database=rpg";
        MySqlConnection conn = new MySqlConnection(connString);

        public string ClasseNome { get; set; }
        public int Strengh { get; set; }
        public int Intell { get; set; }
        public int Charisma { get; set; }
        public int Speed { get; set; }
        public int HP { get; set; }



        public void ConnectionOpen()
        {
            try
            {
                conn.Open();
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public void ConnectionClose()
        {
            conn.Close();
        }



        public void Insert(DAOclassBase adicionar)
        {

            try
            {
                ConnectionOpen();

                MySqlCommand query = new MySqlCommand("INSERT INTO ClassBase(ClasseNome, strengh, intelligence, charisma, speed, HP)" +
                    "VALUES(@classe, @strengh, @intell, @charisma, @speed, @HP)", conn);

                query.Parameters.AddWithValue("@classe", ClasseNome);
                query.Parameters.AddWithValue("@strengh", Strengh);
                query.Parameters.AddWithValue("@intell", Intell);
                query.Parameters.AddWithValue("@charisma", Charisma);
                query.Parameters.AddWithValue("@speed", Speed);
                query.Parameters.AddWithValue("@HP", HP);

                query.ExecuteNonQuery();



            }
            catch (SqlException err)
            {
                MessageBox.Show("ERRO:" + err.Message);
                ConnectionClose();
            }
        }

        public DataTable Search()
        {
            ConnectionOpen();

            try
            {

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();
                string query = "SELECT * FROM ClassBase";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                da.SelectCommand = cmd;
                da.Fill(dt);


                ConnectionClose();
                return dt;
            }
            catch (SqlException err)
            {
                MessageBox.Show("ERRO:" + err.Message);
                ConnectionClose();
                return null;
            }




        }

        public DataTable FillCombox(string filtro)
        {
            ConnectionOpen();

            try
            {
                string query = "SELECT "+filtro+" FROM ClassBase";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                DataTable dt = new DataTable();

                da.SelectCommand = cmd;
                da.Fill(dt);
                ConnectionClose();
                return dt;

            }
            catch (SqlException err)
            {
                MessageBox.Show("ERRO:" + err.Message);
                ConnectionClose();
                return null;
            }
        }

        public DataTable ClassSelection(String ClassSel)
        {
            ConnectionOpen();

            try
            {
                string query = "SELECT * FROM ClassBase WHERE ClasseNome = '"+ClassSel+"';" ;
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                DataTable dt = new DataTable();

                da.SelectCommand = cmd;
                da.Fill(dt);
                ConnectionClose();
                return dt;

            }
            catch (SqlException err)
            {
                MessageBox.Show("ERRO:" + err.Message);
                ConnectionClose();
                return null;
            }
        }
    }
}
