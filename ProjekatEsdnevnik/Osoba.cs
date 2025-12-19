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
    public partial class osoba : Form
    {
        int broj_sloga =0;
        DataTable tabela;
        public osoba()
        {
            InitializeComponent();
        }
        private void Load_Data()
        {
            SqlConnection veza = konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM osoba", veza);
            tabela = new DataTable();
            adapter.Fill(tabela);
        }
        private void Txt_Load()
        {
            if (tabela.Rows.Count == 0)
            {
                txt_Id.Text = "";
                txt_ime.Text = "";
                txt_prezime.Text = "";
                txt_adresa.Text = "";
                txt_jmbg.Text = "";
                txt_email.Text = "";
                txt_pass.Text = "";
                txt_uloga.Text = "";
                btn_delete.Enabled = false;
            }
            else
            {
                txt_Id.Text = tabela.Rows[broj_sloga]["id"].ToString();
                txt_ime.Text = tabela.Rows[broj_sloga]["ime"].ToString();
                txt_prezime.Text = tabela.Rows[broj_sloga]["prezime"].ToString();
                txt_adresa.Text = tabela.Rows[broj_sloga]["adresa"].ToString();
                txt_jmbg.Text = tabela.Rows[broj_sloga]["jmbg"].ToString();
                txt_email.Text = tabela.Rows[broj_sloga]["email"].ToString();
                txt_pass.Text = tabela.Rows[broj_sloga]["pass"].ToString();
                txt_uloga.Text = tabela.Rows[broj_sloga]["uloga"].ToString();
                btn_delete.Enabled = true;
            }
            if (broj_sloga == 0)
            {
                btn_first.Enabled = false;
                btn_previous.Enabled = false;
            }
            else 
            {
                btn_first.Enabled = true;
                btn_previous.Enabled = true;    
            }
            if (broj_sloga == tabela.Rows.Count - 1)
            {
                btn_last.Enabled = false;
                btn_next.Enabled = false;
            }
            else
            {
                btn_last.Enabled = true;
                btn_next.Enabled = true;
            }
        }
        private void osoba_Load(object sender, EventArgs e)
        {
            Load_Data();
            Txt_Load();
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            broj_sloga = 0;
            Txt_Load();
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            broj_sloga--;
            Txt_Load();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            broj_sloga++;
            Txt_Load();
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            broj_sloga = tabela.Rows.Count - 1;
            Txt_Load();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            StringBuilder Naredba = new StringBuilder("INSERT INTO osoba (ime,prezime,adresa,jmbg,email,pass,uloga) VALUES('");
                Naredba.Append(txt_ime.Text + "', '");
                Naredba.Append(txt_prezime.Text + "', '");
                Naredba.Append(txt_adresa.Text + "', '");
                Naredba.Append(txt_jmbg.Text + "', '");
                Naredba.Append(txt_email.Text + "', '");
                Naredba.Append(txt_pass.Text + "', '");
                Naredba.Append(txt_uloga.Text + "')");
            SqlConnection veza = konekcija.Connect();
            SqlCommand komanda = new SqlCommand(Naredba.ToString(), veza);
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            Load_Data();
            broj_sloga = tabela.Rows.Count - 1;
            Txt_Load();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            StringBuilder Naredba = new StringBuilder("UPDATE osoba SET") ;
            Naredba.Append("ime= '" + txt_ime.Text + "',");
            Naredba.Append("prezime= '" + txt_prezime.Text + "',");
            Naredba.Append("adresa= '" + txt_adresa.Text + "',");
            Naredba.Append("jmbg= '" + txt_jmbg.Text + "',");
            Naredba.Append("email= '" + txt_email.Text + "',");
            Naredba.Append("pass= '" + txt_pass.Text + "',");
            Naredba.Append("uloga= '" + txt_uloga.Text + "' ");
            Naredba.Append("WHERE id = " + txt_Id.Text);
            SqlConnection veza = konekcija.Connect();
            SqlCommand komanda = new SqlCommand(Naredba.ToString(), veza);
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Load_Data();
            Txt_Load();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string Naredba = "DELETE FROM osoba WHERE id =" + txt_Id.Text;
            SqlConnection veza = konekcija.Connect();
            SqlCommand komanda = new SqlCommand(Naredba, veza);
            Boolean brisano = false;
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
                brisano = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (brisano)
            {
                Load_Data();
                if (broj_sloga > 0) broj_sloga--;
                Txt_Load();
            }
            Load_Data();
            Txt_Load();
        }
    }
}
