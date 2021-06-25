using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aracyedekparca
{
    class otomobilparca
    {
        private string marka;
        private string model;
        private DateTime uretimYili;
        private string motorGucu;
        private string parcaAdi;
        public static string otoParca = "C:\\AracYedekParca\\otomobil.xml";
        private DataSet dataOto = new DataSet("OtomobilParca");
        private DataTable tabloOto = new DataTable("Otomobiller");
        public otomobilparca()
        {
            DataSetOlustur();
        }
        public otomobilparca(string marka, string model, DateTime uretimYili, string motorGucu, string parcaAdi)
        {
            this.marka = marka;
            this.model = model;
            this.uretimYili = uretimYili;
            this.motorGucu = motorGucu;
            this.parcaAdi = parcaAdi;
            DataSetOlustur();
        }
        private void DataSetOlustur()
        {
            if (System.IO.File.Exists(otoParca))
            {
                dataOto.ReadXml(otoParca);
                tabloOto = dataOto.Tables[0];
            }
            else
            {
                tabloOto.Columns.Add("Marka");
                tabloOto.Columns.Add("Model");
                tabloOto.Columns.Add("UretimYili");
                tabloOto.Columns.Add("MotorGucu");
                tabloOto.Columns.Add("ParcaAdi");
                dataOto.Tables.Add(tabloOto);
                dataOto.WriteXml(otoParca, XmlWriteMode.WriteSchema);

            }

        }
        public void otoparcaEkle()
        {
            DataRow sira = tabloOto.NewRow();
            sira["Marka"] = marka;
            sira["Model"] = model;
            sira["UretimYili"] = uretimYili;
            sira["MotorGucu"] = motorGucu;
            sira["ParcaAdi"] = parcaAdi;
            tabloOto.Rows.Add(sira);
            dataOto.WriteXml(otoParca, XmlWriteMode.WriteSchema);

        }
        public DataTable otoListe()
        {
            return tabloOto;
        }
        public void otoEkle(DataTable dt)
        {
            dataOto.Tables.Clear();
            tabloOto = dt.Copy();
            dataOto.Tables.Add(tabloOto);
            dataOto.WriteXml(otoParca, XmlWriteMode.WriteSchema);
        }
        public void otoKaydet(DataTable dt)
        {
            dataOto.Tables.Clear();
            tabloOto = dt.Copy();
            dataOto.Tables.Add(tabloOto);
            dataOto.WriteXml(otoParca, XmlWriteMode.WriteSchema);
        }

        public DataTable otoMarkaAra(string Marka)
        {
            var netice = from otoAra in tabloOto.AsEnumerable()
                         where otoAra.Field<string>("Marka").ToUpper().Contains(Marka.ToUpper())
                         select otoAra;
            if (netice.Count() > 0)
            {
                DataTable dtNetice = netice.CopyToDataTable<DataRow>();
                return dtNetice;

            }
            else return null;

        }
        public string getMarka()
        {
            return marka;

        }
        public void setMarka(string s)
        {
            this.marka = s;
        }
        public string getModel()
        {
            return model;

        }
        public void setModel(string s)
        {
            this.model = s;

        }
        public DateTime getUretimYili()
        {
            return uretimYili;

        }
        public void setUretimYili(DateTime s)
        {
            this.uretimYili = s;
        }
        public string getMotorGucu()
        {
            return motorGucu;

        }
        public void setMotorGucu(string s)
        {
            this.motorGucu = s;
        }
        public string getParcaAdi()
        {
            return parcaAdi;

        }
        public void setParcaAdi(string s)
        {
            this.parcaAdi = s;
        }


    }
}
