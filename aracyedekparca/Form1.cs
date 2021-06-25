using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aracyedekparca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void parcaekle_Click(object sender, EventArgs e)
        {
            string marka = otomarka.Text;
            otomobilparca op = new otomobilparca();
            DataTable dt = op.otoMarkaAra(marka);
            if (dt == null)
            {
                otomobilparca op1 = new otomobilparca();
                op1.setMarka(otomarka.Text);
                op1.setModel(otomodel.Text);
                op1.setUretimYili(otoyili.Value);
                op1.setMotorGucu(otogucu.Text);
                op1.setParcaAdi(otoparca.Text);
                op1.otoparcaEkle();
                Listele();
            }
        }
        private void Listele()
        {
            otomobilparca op = new otomobilparca();
            DataTable dt = op.otoListe();
            dataGridListe.DataSource = dt;



        }

        private void listele_Click(object sender, EventArgs e)
        {
            Listele();

        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            otomobilparca op = new otomobilparca();
            DataTable dt = (DataTable)dataGridListe.DataSource;
            op.otoKaydet(dt);
        }

        private void sil_Click(object sender, EventArgs e)
        {
            if (dataGridListe.CurrentRow.Cells[0].Value != null)
            {
                dataGridListe.Rows.RemoveAt(dataGridListe.CurrentRow.Index);

            }
            else
                MessageBox.Show("Parça Bulunamadı");
        }
    }
}
