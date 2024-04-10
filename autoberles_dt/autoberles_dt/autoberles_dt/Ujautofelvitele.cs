using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace autoberles_dt
{
    public partial class Ujautofelvitele : Form
    {
        public static string connStr;
        public static MySqlConnection conn;
        public Ujautofelvitele()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=root;database=autoberles_dt;port=3306;password=Admin1234";

            MySqlConnection conn = new MySqlConnection(connStr);

            string rendszam = rendSzamBox.Text;
            string szin = szinBox.Text;
            string nev = nevBox.Text;
            int evjarat = Convert.ToInt32(evjaratBox.Text);
            decimal ar = Convert.ToDecimal(berlesArBox.Text);

            try
            {
                conn.Open();


                string sql = $"INSERT INTO autok (rendszam, szin, nev, evjarat, ar, kategoriaId) VALUES ('{rendszam}','{szin}', '{nev}', '{evjarat}', '{ar}')";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                if (evjarat >= 1991)
                {
                    MessageBox.Show(ex.ToString(), "1991-nél csak korábbi gépjármű lehet.");
                }
                if (ar >= 2500)
                {
                    MessageBox.Show(ex.ToString(), "Minimum 2500 Ft lehet a napi ára.");
                }
                if (true)
                {

                }
            }
            finally
            {
                conn.Close();
            }
        }

        private void rendSzamBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
