using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjekatEsdnevnik
{
    public partial class Upisnica : Form
    {
        public Upisnica()
        {
            InitializeComponent();
        }
        private void PopulateCboxGod()
        {
            SqlConnection veza = konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Skolska_godina", veza);
            DataTable godina = new DataTable();
            adapter.Fill(godina);
            CboxGod.DataSource = godina;
            CboxGod.ValueMember = "id";
            CboxGod.DisplayMember = "naziv";
        }
        private void PopulateCboxOdeljenje()
        {
            SqlConnection veza = konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT id, razred, indeks, godina_id, str(razred)+'-'+indeks as naziv FROM Odeljenje", veza);
            DataTable Odeljenje = new DataTable();
            adapter.Fill(Odeljenje);
            CboxOdeljenje.DataSource = Odeljenje;
            CboxOdeljenje.ValueMember = "id";
            CboxOdeljenje.DisplayMember = "naziv";
        }
        private void PopulateCboxUcenik()
        {
            SqlConnection veza = konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT id, prezime+' '+ime as naziv FROM Osoba", veza);
            DataTable ucenik = new DataTable();
            adapter.Fill(ucenik);
            CboxUcenik.DataSource = ucenik;
            CboxUcenik.ValueMember = "id";
            CboxUcenik.DisplayMember = "naziv";
        }
        private void PopulateDGridView()
        {
            SqlConnection veza = konekcija.Connect();
            string naredba = "SELECT Upisnica.id, ime+' '+prezime as ucenik, str(razred)+'-'+indeks as odel, Odeljenje.Godina_id as god_id, Odeljenje.id as odel_id, Osoba.id as os_id from Upisnica JOIN Osoba ON Osoba_id=Osoba.id JOIN Odeljenje ON Odeljenje_id=Odeljenje.id";
            SqlDataAdapter adapter = new SqlDataAdapter(naredba, veza);
            DataTable tabela = new DataTable();
            adapter.Fill(tabela);
            DGridView.DataSource = tabela;
            DGridView.AllowUserToAddRows = false;
            DGridView.Columns["god_id"].Visible = false;
            DGridView.Columns["odel_id"].Visible = false;
            DGridView.Columns["os_id"].Visible = false;
        }
        private void PopulateCBoxes()
        {
            PopulateCboxGod();
            PopulateCboxOdeljenje();
            PopulateCboxUcenik();
        }
        private void Upisnica_Load(object sender, EventArgs e)
        {
            PopulateCBoxes();
            PopulateDGridView();
        }

        private void DGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            if (DGridView.CurrentRow != null)
            {
                int brSloga = DGridView.CurrentRow.Index;
                CboxGod.SelectedValue = DGridView.Rows[brSloga].Cells["god_id"].Value.ToString();
                CboxOdeljenje.SelectedValue = DGridView.Rows[brSloga].Cells["odel_id"].Value.ToString();
                CboxUcenik.SelectedValue = DGridView.Rows[brSloga].Cells["os_id"].Value.ToString();
                TboxId.Text = DGridView.Rows[brSloga].Cells["id"].Value.ToString();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string naredba = "DELETE FROM upisnica WHERE id=" + TboxId.Text;
            SqlConnection veza = konekcija.Connect();
            SqlCommand komanda = new SqlCommand(naredba, veza);
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
            PopulateDGridView();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string naredba = "UPDATE upisnica SET osoba_id = " + CboxUcenik.SelectedValue.ToString();
            naredba += ", odeljenje_id=" + CboxOdeljenje.SelectedValue.ToString();
            naredba += " WHERE id=" + TboxId.Text;
            SqlConnection veza = konekcija.Connect();
            SqlCommand komanda = new SqlCommand(naredba, veza);
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
            PopulateDGridView();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            string naredba = "INSERT INTO upisnica (odeljenje_id, osoba_id) VALUES(";
            naredba += CboxOdeljenje.SelectedValue.ToString() + ", ";
            naredba += CboxUcenik.SelectedValue.ToString() + ")";
            SqlConnection veza = konekcija.Connect();
            SqlCommand komanda = new SqlCommand(naredba, veza);
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

            PopulateDGridView();
        }
    }
}