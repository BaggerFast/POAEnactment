// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com/

using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Serialization;
using PAOCore;


namespace PAOWinForms
{
    public partial class FormMain : Form
    {
        #region Public and private fields and properties

        public DataHelper Data { get; private set; } = DataHelper.Instance;

        #endregion

        #region Constructor and destructor

        public FormMain()
        {
            InitializeComponent();
        }

        #endregion

        #region Public and private methods

        private void Edit_Click(object sender, EventArgs e)
        {
            FormBaseInfoEdit form = new FormBaseInfoEdit();

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

        private void CreateXML_Click(object sender, EventArgs e)
        {
            Data.AuthorityDate = authorityDate.Text;
            Data.NumberEnd = numberEnd.Text;
            Data.AuthorityNo = authorityNo.Text;


            SaveFileDialog saveDialog = new SaveFileDialog
            {
                Filter = "Extensible Markup Language|*.xml",
                Title = "Save as"
            };
            saveDialog.ShowDialog();

            if (saveDialog.FileName != "")
            {
                FileStream file = (FileStream)saveDialog.OpenFile();
                XmlEntity xml = new XmlEntity();
                XmlSerializer serializer = new XmlSerializer(type: typeof(XmlEntity));
                serializer.Serialize(file, xml);
                file.Close();
                MessageBox.Show("ready");
            }
        }

        private void TextBox_IntParser(object sender, KeyPressEventArgs e)
        {
            if (sender is TextBox)
            {
                Regex regexNum = new Regex("[0-9]");
                if (!regexNum.IsMatch(e.KeyChar.ToString()) && e.KeyChar != Convert.ToChar(8))
                {
                    e.Handled = true;
                }
            }
        }

        #endregion
    }
}
