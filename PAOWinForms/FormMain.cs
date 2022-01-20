// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com/

using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using PAOCore;


namespace PAOWinForms
{
    public partial class FormMain : Form
    {
        private Data data = Data.Instance;

        public FormMain()
        {
            InitializeComponent();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            FormBaseInfoEdit form = new FormBaseInfoEdit();

            form.ShowDialog();

            clientKpp.Text = data.ClientKpp;
            clientInn.Text = data.ClientInn;
            director.Text = data.Director;
            clientName.Text = data.ClientName;
            index.Text = data.Index;
            codeRegion.Text = data.CodeRegion;
            apartment.Text = data.Apartment;
            street.Text = data.Street;
            build.Text = data.Build;
            housing.Text = data.Housing;
            district.Text = data.District;
            settlement.Text = data.Settlement;
            city.Text = data.City;
        }

        private void AddUp_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.ShowDialog();
        }

        private void CreateXML_Click(object sender, EventArgs e)
        {
            data.AuthorityDate = authorityDate.Text;
            data.NumberEnd = numberEnd.Text;
            data.AuthorityNo = authorityNo.Text;
        

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}