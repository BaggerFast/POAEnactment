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
        private Data data = Data.Instance;

        public FormBaseInfoEdit()
        {
            InitializeComponent();

            clientInn.Text = data.ClientInn;
            clientKpp.Text = data.ClientKpp;
            lastName.Text = data.FirstName;
            firstName.Text = data.LastName;
            clientName.Text = data.ClientName;
            middleName.Text = data.MiddleName;
            index.Text = data.Index;
            codeRegion.Text = data.CodeRegion;
            apartment.Text = data.Apartment;
            street.Text = data.Street;
            build.Text = data.Build;
            housing.Text = data.Housing;
            district.Text = data.District;
            settlement.Text = data.Settlement;
            city.Text = data.City;
            clientBasedOn.Text = data.ClientBasedOn;
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
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                data.ClientName = clientName.Text;
                data.ClientInn = clientInn.Text;
                data.ClientKpp = clientKpp.Text;
                data.LastName = lastName.Text;
                data.FirstName = firstName.Text;
                data.MiddleName = middleName.Text;
                data.Index = index.Text;
                data.CodeRegion = codeRegion.Text;
                data.District = district.Text;
                data.Street = street.Text;
                data.Build = build.Text;
                data.Housing = housing.Text;
                data.Apartment = apartment.Text;

                data.Settlement = settlement.Text;
                data.City = city.Text;
                data.ClientBasedOn = clientBasedOn.Text;
                Close();
            }
            catch (EmptyFieldException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void Сancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
