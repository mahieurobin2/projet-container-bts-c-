using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Collections;

namespace containers
{
    class BDD //classe
    {
        private MySqlConnection connection;

        private void InitConnection()
        {
            this.connection = new MySqlConnection("SERVER=127.0.0.1;DATABASE=containers;UID=root;PASSWORD=");
        }

        public BDD()
        {
            this.InitConnection();
        }

        public void ADD_N(string Dimension, string BIC_CODE)
        {
            try
            {
                this.connection.Open();
                MySqlCommand inserer_N = this.connection.CreateCommand();
                inserer_N.CommandText = "INSERT INTO container (Dimension, BIC_CODE) VALUES (@N, @BIC)";
                inserer_N.Parameters.AddWithValue("@N", Dimension);
                inserer_N.Parameters.AddWithValue("@BIC", BIC_CODE);
                inserer_N.ExecuteNonQuery();
                this.connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public ArrayList Lire_BC()
        {
            ArrayList List = new ArrayList();
            try
            {
                this.connection.Open();
                MySqlCommand lire = this.connection.CreateCommand();
                lire.CommandText = "SELECT * FROM container";
                MySqlDataReader Lire = lire.ExecuteReader();
                while (Lire.Read())
                {
                    List.Add(Lire.GetString("BIC_CODE"));
                }
                this.connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return List;
        }

        public int Lire_dimension(String BIC_CODE)
        {
            int dimension = 0;
            try
            {
                this.connection.Open();
                MySqlCommand lire_D = this.connection.CreateCommand();
                lire_D.CommandText = "SELECT Dimension FROM container WHERE BIC_CODE=@BIC_CODE";
                lire_D.Parameters.AddWithValue("@BIC_CODE", BIC_CODE);
                MySqlDataReader Lire = lire_D.ExecuteReader();
                while (Lire.Read())
                {
                    dimension = Lire.GetInt16("dimension");
                }
                this.connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dimension;
        }
    }
}

