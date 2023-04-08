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

namespace Интернет_провайдер
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Program.TarifInet = 600;
            Program.TarifTvInet = 1600;
            Program.tarifTV = 1000;
            int bal,shet;
            string fam, imya, tarif;
            DB db = new DB();
            SqlCommand command = new SqlCommand("Select Familiya,Imya,Tarif,Money,Schet from Provider where Schet = '" + Program.chet + "'", db.getConnection());
            db.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {

                    bal = reader.GetInt32(3);
                    fam = reader.GetString(0);
                    imya = reader.GetString(1);
                    shet = reader.GetInt32(4);
                    tarif = reader.GetString(2);
                    Mone.Text = Convert.ToString(bal);
                    surna.Text = fam;
                    nameLab.Text = imya;
                    schet.Text = Convert.ToString(shet);
                    Tar.Text = tarif;
                    Program.tarifName = tarif;
                    Program.kolvo = Convert.ToInt32(Mone.Text);
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tarifi form = new Tarifi();
           
            if (form.ShowDialog() == DialogResult.OK)
            {

                DB db = new DB();

                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand("update Provider set Tarif ='" + form.tarifiBox.Text + "' where  Schet='" + Program.chet + "'", db.getConnection());


                db.openConnection();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                command.ExecuteNonQuery();

                
            }
        }

        private void udateButton_Click(object sender, EventArgs e)
        {
            int bal, shet;
            string fam, imya, tarif;
            DB db = new DB();
            SqlCommand command = new SqlCommand("Select Familiya,Imya,Tarif,Money,Schet from Provider where Schet = '" + Program.chet + "'", db.getConnection());
            db.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {

                    bal = reader.GetInt32(3);
                    Program.money = bal;
                    fam = reader.GetString(0);
                    imya = reader.GetString(1);
                    shet = reader.GetInt32(4);
                    tarif = reader.GetString(2);
                    Mone.Text = Convert.ToString(bal);
                    surna.Text = fam;
                    nameLab.Text = imya;
                    schet.Text = Convert.ToString(shet);
                    Tar.Text = tarif;
                    Program.tarifName = tarif;
                    Program.kolvo = Convert.ToInt32(Mone.Text);
                }
            }
        }

        private void Mone_Click(object sender, EventArgs e)
        {
            Popoln form = new Popoln();
            if(form.ShowDialog() == DialogResult.OK)
            {
                DB db = new DB();

                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand("update Provider set Money = Money + '" + form.moneyBox.Text + "' where  Schet='" + Program.chet + "'", db.getConnection());


                db.openConnection();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                command.ExecuteNonQuery();
            }
        }
    }
}
