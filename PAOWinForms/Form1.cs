using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace PAOWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new Form2();
            
            form.ShowDialog();
            
            this.clientKpp.Text = Data.clientKpp;
            this.clientInn.Text = Data.clientInn;
            this.director.Text = Data.director;
            this.clientName.Text = Data.clientName;
            this.index.Text = Data.index;
            this.codeRegion.Text = Data.codeRegion;
            this.apartment.Text = Data.apartment;
            this.street.Text = Data.street;
            this.build.Text = Data.build;
            this.housing.Text = Data.housing;
            this.district.Text = Data.district;
            this.settlement.Text = Data.settlement;
            this.city.Text = Data.city;
        }


        private void button4_Click(object sender, EventArgs e)
        {
            var form = new Form3();
            form.ShowDialog();
        }

        private void createXML_Click(object sender, EventArgs e)
        {
            Data.authorityDate = this.authorityDate.Text;
            Data.numberEnd = this.numberEnd.Text;
            Data.authorityNo = this.authorityNo.Text;


            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Extensible Markup Language|*.xml";
            saveFileDialog.Title = "Save as";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                FileStream file = (FileStream)saveFileDialog.OpenFile();
                var xml = new Xml();
                XmlSerializer serializer = new XmlSerializer(type: typeof(Xml));
                serializer.Serialize(file, xml);
                file.Close();
                MessageBox.Show("ready");
            }

           
        }
    }
}