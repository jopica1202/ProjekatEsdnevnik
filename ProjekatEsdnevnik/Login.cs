using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjekatEsdnevnik
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_ok_Click(object sender, EventArgs e)
        {
            if (Txt_name.Text == "" || Txt_pass.Text == "")
            {
                MessageBox.Show("Unesite mail i lozinku");
                return;
            }
            else
            {
                try
                {
                    SqlConnection veza = konekcija.Connect();
                    SqlCommand komanda = new SqlCommand("SELECT * FROM osoba WHERE email=@username", veza);
                    komanda.Parameters.AddWithValue("@username", Txt_name.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(komanda);
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);
                    int brojac = tabela.Rows.Count;
                    if (brojac == 1)
                    {
                        if (String.Compare(tabela.Rows[0]["pass"].ToString(), Txt_pass.Text) == 0)
                        {
                            MessageBox.Show("login succesful!");
                            Program.user_ime = tabela.Rows[0]["ime"].ToString();
                            Program.user_prezime = tabela.Rows[0]["prezime"].ToString();
                            Program.user_uloga = (int) tabela.Rows[0]["uloga"];
                            this.Hide();
                            Glavna frm_glavna = new Glavna();
                            frm_glavna.Show();
                        }
                        else
                        {
                            MessageBox.Show("Neispravna lozinka");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nepostojeci e-mail!");
                    }
                }
                catch (Exception greska)
                {
                    MessageBox.Show(greska.Message);
                }
            }
        }
    }
}
