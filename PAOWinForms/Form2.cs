using System;
using System.ComponentModel;
using System.Windows.Forms;
using PAOCore;

namespace PAOWinForms
{
    public partial class Form2 : Form
    {
        public Form2()
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
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            Data.ClientInn = clientInn.Text;
            Data.ClientKpp = clientKpp.Text;
            Data.FirstName = lastName.Text;
            Data.LastName = firstName.Text;
            Data.ClientName = clientName.Text;
            Data.MiddleName = middleName.Text;
            Data.Index = index.Text;
            Data.CodeRegion = codeRegion.Text;
            Data.Apartment = apartment.Text;
            Data.Street = street.Text;
            Data.Build = build.Text;
            Data.Housing = housing.Text;
            Data.District = district.Text;
            Data.Settlement = settlement.Text;
            Data.City = city.Text;
        }

        private void radioSettlement_CheckedChanged(object sender, EventArgs e)
        {
            syncRadioAndText(sender, ref this.settlement);
        }

        private void radioCity_CheckedChanged(object sender, EventArgs e)
        {
            syncRadioAndText(sender, ref this.city);
        }

        private void syncRadioAndText(object sender, ref TextBox text)
        {
            RadioButton btn = (RadioButton)sender;
            text.Enabled = btn.Checked;
            if (!text.Enabled)
                text.Text = "";
        }
    }
}
