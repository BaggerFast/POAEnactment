using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAOWinForms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            this.clientInn.Text = Data.clientInn;
            this.clientKpp.Text = Data.clientKpp;
            this.lastName.Text = Data.firstName;
            this.firstName.Text = Data.lastName;
            this.clientName.Text = Data.clientName;
            this.middleName.Text = Data.middleName;
            this.index.Text = Data.index;
            this.codeRegion.Text = Data.codeRegion;
            this.apartment.Text = Data.apartment;
            this.street.Text = Data.street;
            this.build.Text = Data.build;
            this.housing.Text = Data.housing;
            this.district.Text = Data.district;
            this.settlement.Text = Data.settlement;
            this.city.Text = Data.city;
            this.clientBasedOn.Text = Data.clientBasedOn;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            Data.clientInn = this.clientInn.Text;
            Data.clientKpp = this.clientKpp.Text;
            Data.firstName = this.lastName.Text;
            Data.lastName = this.firstName.Text;
            Data.clientName = this.clientName.Text;
            Data.middleName = this.middleName.Text;
            Data.index = this.index.Text;
            Data.codeRegion = this.codeRegion.Text;
            Data.apartment = this.apartment.Text;
            Data.street = this.street.Text;
            Data.build = this.build.Text;
            Data.housing = this.housing.Text;
            Data.district = this.district.Text;
            Data.settlement = this.settlement.Text;
            Data.city = this.city.Text;
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

        private void inn_Validating(object sender, CancelEventArgs e)
        {
            MessageBox.Show("dawdadad");
            if (clientInn.Text != "something")
                e.Cancel = true;
        }
    }
}
