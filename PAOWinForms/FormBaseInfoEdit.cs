// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com/

using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using PAOCore;

namespace PAOWinForms
{
    public partial class FormBaseInfoEdit : Form
    {
        #region Public and private fields and properties

        public DataHelper Data { get; private set; } = DataHelper.Instance;

        #endregion

        #region Constructor and destructor

        public FormBaseInfoEdit()
        {
            InitializeComponent();

            clientInn.Text = Data.ClientInn;
            clientKpp.Text = Data.ClientKpp;
            lastName.Text = Data.FirstName;
            firstName.Text = Data.LastName;
            clientName.Text = Data.ClientName;
            middleName.Text = Data.MiddleName;
            index.Text = Data.Index;
            codeRegion.Text = Data.CodeRegion;
            apartment.Text = Data.Apartment;
            street.Text = Data.Street;
            build.Text = Data.Build;
            housing.Text = Data.Housing;
            district.Text = Data.District;
            settlement.Text = Data.Settlement;
            city.Text = Data.City;
            clientBasedOn.Text = Data.ClientBasedOn;

            RadioButtons_Init();

        }

        #endregion

        #region Public and private methods

        private void RadioButtons_Init()
        {
            if (city.Text == "" && settlement.Text != "")
            {
                settlement.Enabled = true;
                radioSettlement.Checked = true;

                radioCity.Checked = false;
                city.Enabled = false;
            }
        }

        private void RadioSettlement_CheckedChanged(object sender, EventArgs e)
        {
            SyncRadioAndText(sender, settlement);
        }

        private void RadioCity_CheckedChanged(object sender, EventArgs e)
        {
            SyncRadioAndText(sender, city);
        }

        /// <summary>
        /// Sync Radio Button and TextBox.
        /// </summary>
        private void SyncRadioAndText(object sender, TextBox text)
        {
            RadioButton btn = (RadioButton)sender;
            text.Enabled = btn.Checked;
            if (!text.Enabled)
                text.Text = "";
        }

        /// <summary>
        /// Field value int control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        private void TextBox_CharParser(object sender, KeyPressEventArgs e)
        {
            if (sender is TextBox)
            {
                Regex regexNum = new Regex("[0-9]");
                if (regexNum.IsMatch(e.KeyChar.ToString()))
                {
                    e.Handled = true;
                }
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Data.ClientName = clientName.Text;
            Data.ClientInn = clientInn.Text;
            Data.ClientKpp = clientKpp.Text;
            Data.LastName = lastName.Text;
            Data.FirstName = firstName.Text;
            Data.MiddleName = middleName.Text;
            Data.Index = index.Text;
            Data.CodeRegion = codeRegion.Text;
            Data.District = district.Text;
            Data.Street = street.Text;
            Data.Build = build.Text;
            Data.Housing = housing.Text;
            Data.Apartment = apartment.Text;
            Data.Settlement = settlement.Text;
            Data.City = city.Text;
            Data.ClientBasedOn = clientBasedOn.Text;

            if (!Data.IsValid())
                MessageBox.Show(Data.Errors[0].ErrorMessage);
            else Close();
        }

        private void Сancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion
    }
}
