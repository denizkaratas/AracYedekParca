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
    public partial class motorsiklet : Form
    {
        public motorsiklet()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            motorsikletparca mp = new motorsikletparca();
            DataTable dt = (DataTable)dataGridView1.DataSource;
            mp.motoKaydet(dt);
        }

        private void parcaekle_Click(object sender, EventArgs e)
        {
            string marka = motomarka.Text;
            motorsikletparca mp = new motorsikletparca();
            DataTable dt = mp.motoMarkaAra(marka);
            if (dt == null)
            {
                motorsikletparca mp1 = new motorsikletparca();
                mp1.setMarka(motomarka.Text);
                mp1.setModel(motomodel.Text);
                mp1.setUretimYili(motoyili.Value);
                mp1.setMotorGucu(motogucu.Text);
                mp1.setParcaAdi(motoparca.Text);
                mp1.setEkipmanParcasi(ekipmanparcasi.Text);
                mp1.setKaskMarkasi(kaskmarkasi.Text);
                mp1.motoparcaEkle();
                Listele();
            }
        }
        private void Listele()
        {
            motorsikletparca mp = new motorsikletparca();
            DataTable dt = mp.motoListe();
            dataGridView1.DataSource = dt;



        }

        private void listele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void sil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[0].Value != null)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);

            }
            else
                MessageBox.Show("Parça Bulunamadı");
        }
    }

}
