using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aracyedekparca
{
    class motorsikletparca : otomobilparca

    {
        private string ekipmanParcasi;
        private string kaskMarkasi;
        public static string motoParca = "C:\\AracYedekParca\\motorsiklet.xml";
        private DataSet dataMoto = new DataSet("MotorsikletParca");
        private DataTable tabloMoto = new DataTable("Motorsikletler");

        public motorsikletparca()
        {
            DataSetOlustur();
        }
        public motorsikletparca(string kaskMarkasi, string ekipman)
        {
            this.kaskMarkasi = kaskMarkasi;
            this.ekipmanParcasi = ekipman;
            DataSetOlustur();
        }
        private void DataSetOlustur()
        {
            if (System.IO.File.Exists(motoParca))
            {
                dataMoto.ReadXml(motoParca);
                tabloMoto = dataMoto.Tables[0];
            }
            else
            {
                tabloMoto.Columns.Add("Marka");
                tabloMoto.Columns.Add("Model");
                tabloMoto.Columns.Add("UretimYili");
                tabloMoto.Columns.Add("MotorGucu");
                tabloMoto.Columns.Add("ParcaAdi");
                tabloMoto.Columns.Add("EkipmanParcasi");
                tabloMoto.Columns.Add("KaskMarkasi");
                dataMoto.Tables.Add(tabloMoto);

                dataMoto.WriteXml(motoParca, XmlWriteMode.WriteSchema);
            }


        }

        public void motoparcaEkle()
        {
            DataRow sira = tabloMoto.NewRow();

            sira["EkipmanParcasi"] = ekipmanParcasi;
            sira["KaskMarkasi"] = kaskMarkasi;

            tabloMoto.Rows.Add(sira);
            dataMoto.WriteXml(motoParca, XmlWriteMode.WriteSchema);

        }
        public DataTable motoListe()
        {
            return tabloMoto;
        }
        public void motoEkle(DataTable dt)
        {
            dataMoto.Tables.Clear();
            tabloMoto = dt.Copy();
            dataMoto.Tables.Add(tabloMoto);
            dataMoto.WriteXml(motoParca, XmlWriteMode.WriteSchema);
        }
        public void motoKaydet(DataTable dt)
        {
            dataMoto.Tables.Clear();
            tabloMoto = dt.Copy();
            dataMoto.Tables.Add(tabloMoto);
            dataMoto.WriteXml(motoParca, XmlWriteMode.WriteSchema);
        }

        public DataTable motoMarkaAra(string Marka)
        {
            var netice = from motoAra in tabloMoto.AsEnumerable()
                         where motoAra.Field<string>("Marka").ToUpper().Contains(Marka.ToUpper())
                         select motoAra;
            if (netice.Count() > 0)
            {
                DataTable dtNetice = netice.CopyToDataTable<DataRow>();
                return dtNetice;

            }
            else return null;

        }

        public string getEkipmanParcasi()
        {
            return ekipmanParcasi;
        }
        public void setEkipmanParcasi(string s)
        {
            this.ekipmanParcasi = s;
        }
        public string getKaskMarkasi()
        {
            return kaskMarkasi;
        }
        public void setKaskMarkasi(string s)
        {
            this.kaskMarkasi = s;
        }



    }
}
