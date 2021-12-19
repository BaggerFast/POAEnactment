
namespace PAOWinForms
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.clientName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.clientKpp = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.clientInn = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.middleName = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioCity = new System.Windows.Forms.RadioButton();
            this.settlement = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.radioSettlement = new System.Windows.Forms.RadioButton();
            this.apartment = new System.Windows.Forms.TextBox();
            this.housing = new System.Windows.Forms.TextBox();
            this.build = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.street = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.district = new System.Windows.Forms.TextBox();
            this.codeRegion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.index = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.clientBasedOn = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // clientName
            // 
            resources.ApplyResources(this.clientName, "clientName");
            this.clientName.Name = "clientName";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // clientKpp
            // 
            resources.ApplyResources(this.clientKpp, "clientKpp");
            this.clientKpp.Name = "clientKpp";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // clientInn
            // 
            this.clientInn.CausesValidation = false;
            resources.ApplyResources(this.clientInn, "clientInn");
            this.clientInn.Name = "clientInn";
            this.clientInn.ShortcutsEnabled = false;
            this.clientInn.Validating += new System.ComponentModel.CancelEventHandler(this.inn_Validating);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.middleName);
            this.groupBox1.Controls.Add(this.firstName);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lastName);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // middleName
            // 
            resources.ApplyResources(this.middleName, "middleName");
            this.middleName.Name = "middleName";
            // 
            // firstName
            // 
            resources.ApplyResources(this.firstName, "firstName");
            this.firstName.Name = "firstName";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // lastName
            // 
            resources.ApplyResources(this.lastName, "lastName");
            this.lastName.Name = "lastName";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioCity);
            this.groupBox2.Controls.Add(this.settlement);
            this.groupBox2.Controls.Add(this.city);
            this.groupBox2.Controls.Add(this.radioSettlement);
            this.groupBox2.Controls.Add(this.apartment);
            this.groupBox2.Controls.Add(this.housing);
            this.groupBox2.Controls.Add(this.build);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.street);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.district);
            this.groupBox2.Controls.Add(this.codeRegion);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.index);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // radioCity
            // 
            resources.ApplyResources(this.radioCity, "radioCity");
            this.radioCity.Checked = true;
            this.radioCity.Name = "radioCity";
            this.radioCity.TabStop = true;
            this.radioCity.UseVisualStyleBackColor = true;
            this.radioCity.CheckedChanged += new System.EventHandler(this.radioCity_CheckedChanged);
            // 
            // settlement
            // 
            resources.ApplyResources(this.settlement, "settlement");
            this.settlement.Name = "settlement";
            // 
            // city
            // 
            resources.ApplyResources(this.city, "city");
            this.city.Name = "city";
            // 
            // radioSettlement
            // 
            resources.ApplyResources(this.radioSettlement, "radioSettlement");
            this.radioSettlement.Name = "radioSettlement";
            this.radioSettlement.UseVisualStyleBackColor = true;
            this.radioSettlement.CheckedChanged += new System.EventHandler(this.radioSettlement_CheckedChanged);
            // 
            // apartment
            // 
            resources.ApplyResources(this.apartment, "apartment");
            this.apartment.Name = "apartment";
            // 
            // housing
            // 
            resources.ApplyResources(this.housing, "housing");
            this.housing.Name = "housing";
            // 
            // build
            // 
            resources.ApplyResources(this.build, "build");
            this.build.Name = "build";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // street
            // 
            resources.ApplyResources(this.street, "street");
            this.street.Name = "street";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // district
            // 
            resources.ApplyResources(this.district, "district");
            this.district.Name = "district";
            // 
            // codeRegion
            // 
            resources.ApplyResources(this.codeRegion, "codeRegion");
            this.codeRegion.Name = "codeRegion";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // index
            // 
            resources.ApplyResources(this.index, "index");
            this.index.Name = "index";
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            // 
            // textBox18
            // 
            resources.ApplyResources(this.textBox18, "textBox18");
            this.textBox18.Name = "textBox18";
            this.textBox18.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox18);
            this.groupBox3.Controls.Add(this.label18);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // clientBasedOn
            // 
            this.clientBasedOn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientBasedOn.FormattingEnabled = true;
            resources.ApplyResources(this.clientBasedOn, "clientBasedOn");
            this.clientBasedOn.Items.AddRange(new object[] {
            resources.GetString("clientBasedOn.Items"),
            resources.GetString("clientBasedOn.Items1"),
            resources.GetString("clientBasedOn.Items2"),
            resources.GetString("clientBasedOn.Items3"),
            resources.GetString("clientBasedOn.Items4")});
            this.clientBasedOn.Name = "clientBasedOn";
            this.clientBasedOn.Tag = "";
            // 
            // label20
            // 
            resources.ApplyResources(this.label20, "label20");
            this.label20.Name = "label20";
            // 
            // Form2
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clientBasedOn);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.clientKpp);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.clientInn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clientName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox clientName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox clientKpp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox middleName;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox district;
        private System.Windows.Forms.TextBox codeRegion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox index;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox street;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox build;
        private System.Windows.Forms.TextBox apartment;
        private System.Windows.Forms.TextBox housing;
        private System.Windows.Forms.TextBox clientInn;
        private System.Windows.Forms.ComboBox clientBasedOn;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.RadioButton radioSettlement;
        private System.Windows.Forms.TextBox settlement;
        private System.Windows.Forms.RadioButton radioCity;
    }
}