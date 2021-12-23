namespace PAOWinForms
{
    partial class FormMain
    {

        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.edit = new System.Windows.Forms.Button();
            this.createXML = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numberEnd = new System.Windows.Forms.DateTimePicker();
            this.authorityDate = new System.Windows.Forms.DateTimePicker();
            this.authorityNo = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.director = new System.Windows.Forms.TextBox();
            this.clientKpp = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.apartment = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.street = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.district = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.housing = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.settlement = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.codeRegion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.build = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.index = new System.Windows.Forms.TextBox();
            this.clientInn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clientName = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.AddUp = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Фамилия = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Имя = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Отчество = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ДатаВыдачи = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.МестоВыдачи = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.СерияНомер = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.НомерТелефона = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // edit
            // 
            resources.ApplyResources(this.edit, "edit");
            this.edit.Name = "edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // createXML
            // 
            resources.ApplyResources(this.createXML, "createXML");
            this.createXML.Name = "createXML";
            this.createXML.UseVisualStyleBackColor = true;
            this.createXML.Click += new System.EventHandler(this.CreateXML_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numberEnd);
            this.groupBox2.Controls.Add(this.authorityDate);
            this.groupBox2.Controls.Add(this.authorityNo);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.director);
            this.groupBox2.Controls.Add(this.clientKpp);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.clientInn);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.clientName);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // numberEnd
            // 
            this.numberEnd.Checked = false;
            resources.ApplyResources(this.numberEnd, "numberEnd");
            this.numberEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.numberEnd.MaxDate = new System.DateTime(2050, 2, 1, 0, 0, 0, 0);
            this.numberEnd.MinDate = new System.DateTime(2000, 2, 1, 0, 0, 0, 0);
            this.numberEnd.Name = "numberEnd";
            // 
            // authorityDate
            // 
            this.authorityDate.Checked = false;
            resources.ApplyResources(this.authorityDate, "authorityDate");
            this.authorityDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.authorityDate.MaxDate = new System.DateTime(2050, 2, 1, 0, 0, 0, 0);
            this.authorityDate.MinDate = new System.DateTime(2000, 2, 1, 0, 0, 0, 0);
            this.authorityDate.Name = "authorityDate";
            // 
            // authorityNo
            // 
            resources.ApplyResources(this.authorityNo, "authorityNo");
            this.authorityNo.Name = "authorityNo";
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // director
            // 
            resources.ApplyResources(this.director, "director");
            this.director.Name = "director";
            this.director.ReadOnly = true;
            // 
            // clientKpp
            // 
            resources.ApplyResources(this.clientKpp, "clientKpp");
            this.clientKpp.Name = "clientKpp";
            this.clientKpp.ReadOnly = true;
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.apartment);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.street);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.district);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.housing);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.settlement);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.codeRegion);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.build);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.city);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.index);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // apartment
            // 
            resources.ApplyResources(this.apartment, "apartment");
            this.apartment.Name = "apartment";
            this.apartment.ReadOnly = true;
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // street
            // 
            resources.ApplyResources(this.street, "street");
            this.street.Name = "street";
            this.street.ReadOnly = true;
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // district
            // 
            resources.ApplyResources(this.district, "district");
            this.district.Name = "district";
            this.district.ReadOnly = true;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // housing
            // 
            resources.ApplyResources(this.housing, "housing");
            this.housing.Name = "housing";
            this.housing.ReadOnly = true;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // settlement
            // 
            resources.ApplyResources(this.settlement, "settlement");
            this.settlement.Name = "settlement";
            this.settlement.ReadOnly = true;
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // codeRegion
            // 
            resources.ApplyResources(this.codeRegion, "codeRegion");
            this.codeRegion.Name = "codeRegion";
            this.codeRegion.ReadOnly = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // build
            // 
            resources.ApplyResources(this.build, "build");
            this.build.Name = "build";
            this.build.ReadOnly = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // city
            // 
            resources.ApplyResources(this.city, "city");
            this.city.Name = "city";
            this.city.ReadOnly = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // index
            // 
            resources.ApplyResources(this.index, "index");
            this.index.Name = "index";
            this.index.ReadOnly = true;
            // 
            // clientInn
            // 
            resources.ApplyResources(this.clientInn, "clientInn");
            this.clientInn.Name = "clientInn";
            this.clientInn.ReadOnly = true;
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
            this.clientName.ReadOnly = true;
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // AddUp
            // 
            resources.ApplyResources(this.AddUp, "AddUp");
            this.AddUp.Name = "AddUp";
            this.AddUp.UseVisualStyleBackColor = true;
            this.AddUp.Click += new System.EventHandler(this.AddUp_Click);
            // 
            // button5
            // 
            resources.ApplyResources(this.button5, "button5");
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Фамилия,
            this.Имя,
            this.Отчество,
            this.ДатаВыдачи,
            this.МестоВыдачи,
            this.СерияНомер,
            this.НомерТелефона});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            // 
            // Фамилия
            // 
            resources.ApplyResources(this.Фамилия, "Фамилия");
            this.Фамилия.Name = "Фамилия";
            // 
            // Имя
            // 
            resources.ApplyResources(this.Имя, "Имя");
            this.Имя.Name = "Имя";
            // 
            // Отчество
            // 
            resources.ApplyResources(this.Отчество, "Отчество");
            this.Отчество.Name = "Отчество";
            // 
            // ДатаВыдачи
            // 
            resources.ApplyResources(this.ДатаВыдачи, "ДатаВыдачи");
            this.ДатаВыдачи.Name = "ДатаВыдачи";
            // 
            // МестоВыдачи
            // 
            resources.ApplyResources(this.МестоВыдачи, "МестоВыдачи");
            this.МестоВыдачи.Name = "МестоВыдачи";
            // 
            // СерияНомер
            // 
            resources.ApplyResources(this.СерияНомер, "СерияНомер");
            this.СерияНомер.Name = "СерияНомер";
            // 
            // НомерТелефона
            // 
            resources.ApplyResources(this.НомерТелефона, "НомерТелефона");
            this.НомерТелефона.Name = "НомерТелефона";
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.AddUp);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.createXML);
            this.Controls.Add(this.edit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button createXML;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox clientName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox index;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox apartment;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox street;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox district;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox housing;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox settlement;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox codeRegion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox build;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox clientInn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox director;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button AddUp;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Фамилия;
        private System.Windows.Forms.DataGridViewTextBoxColumn Имя;
        private System.Windows.Forms.DataGridViewTextBoxColumn Отчество;
        private System.Windows.Forms.DataGridViewTextBoxColumn ДатаВыдачи;
        private System.Windows.Forms.DataGridViewTextBoxColumn МестоВыдачи;
        private System.Windows.Forms.DataGridViewTextBoxColumn СерияНомер;
        private System.Windows.Forms.DataGridViewTextBoxColumn НомерТелефона;
        private System.Windows.Forms.DateTimePicker authorityDate;
        private System.Windows.Forms.TextBox authorityNo;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox clientKpp;
        private System.Windows.Forms.DateTimePicker numberEnd;
    }
}