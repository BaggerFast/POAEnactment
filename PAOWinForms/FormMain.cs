using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using PAOCore;


namespace PAOWinForms
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();

            form.ShowDialog();

            clientKpp.Text = Data.ClientKpp;
            clientInn.Text = Data.ClientInn;
            director.Text = Data.Director;
            clientName.Text = Data.ClientName;
            index.Text = Data.Index;
            codeRegion.Text = Data.CodeRegion;
            apartment.Text = Data.Apartment;
            street.Text = Data.Street;
            build.Text = Data.Build;
            housing.Text = Data.Housing;
            district.Text = Data.District;
            settlement.Text = Data.Settlement;
            city.Text = Data.City;
        }

        private void AddUp_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.ShowDialog();
        }

        private void createXML_Click(object sender, EventArgs e)
        {
            Data.AuthorityDate = authorityDate.Text;
            Data.NumberEnd = numberEnd.Text;
            Data.AuthorityNo = authorityNo.Text;


            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Extensible Markup Language|*.xml";
            saveDialog.Title = "Save as";
            saveDialog.ShowDialog();

            if (saveDialog.FileName != "")
            {
                FileStream file = (FileStream)saveDialog.OpenFile();
                var xml = new Xml();
                XmlSerializer serializer = new XmlSerializer(type: typeof(Xml));
                serializer.Serialize(file, xml);
                file.Close();
                MessageBox.Show("ready");
            }


        }
    }
}