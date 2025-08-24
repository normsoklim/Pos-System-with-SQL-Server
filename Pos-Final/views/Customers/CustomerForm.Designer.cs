namespace Pos_Final.views.Customers
{
    partial class CustomerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.roundControlHeaderCustomer = new RoundTextBoxProject.RoundControl();
            this.roundControlCustomer = new RoundTextBoxProject.RoundControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.dgCustomer = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roundControl2 = new RoundTextBoxProject.RoundControl();
            this.txtSearchCustomer = new System.Windows.Forms.TextBox();
            this.panelCustomer = new System.Windows.Forms.Panel();
            this.btnCustomerUpdate = new System.Windows.Forms.Button();
            this.roundControl7 = new RoundTextBoxProject.RoundControl();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.roundControl5 = new RoundTextBoxProject.RoundControl();
            this.btnCustomerSV = new System.Windows.Forms.Button();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.roundControl6 = new RoundTextBoxProject.RoundControl();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rcCusotmerInput = new RoundTextBoxProject.RoundControl();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label7 = new System.Windows.Forms.Label();
            this.roundControl1 = new RoundTextBoxProject.RoundControl();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomer)).BeginInit();
            this.panelCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // roundControlHeaderCustomer
            // 
            this.roundControlHeaderCustomer.BackColor = System.Drawing.Color.LightGray;
            this.roundControlHeaderCustomer.BackgroundColor = System.Drawing.Color.Teal;
            this.roundControlHeaderCustomer.BorderColor = System.Drawing.SystemColors.Control;
            this.roundControlHeaderCustomer.BorderWidth = 1F;
            this.roundControlHeaderCustomer.Location = new System.Drawing.Point(12, -1);
            this.roundControlHeaderCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.roundControlHeaderCustomer.Name = "roundControlHeaderCustomer";
            this.roundControlHeaderCustomer.Radius = 40;
            this.roundControlHeaderCustomer.Size = new System.Drawing.Size(1788, 88);
            this.roundControlHeaderCustomer.TabIndex = 16;
            this.roundControlHeaderCustomer.Load += new System.EventHandler(this.roundControlHeaderCustomer_Load);
            // 
            // roundControlCustomer
            // 
            this.roundControlCustomer.BackColor = System.Drawing.Color.LightGray;
            this.roundControlCustomer.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.roundControlCustomer.BorderColor = System.Drawing.Color.LightGray;
            this.roundControlCustomer.BorderWidth = 1F;
            this.roundControlCustomer.Location = new System.Drawing.Point(11, 108);
            this.roundControlCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.roundControlCustomer.Name = "roundControlCustomer";
            this.roundControlCustomer.Radius = 30;
            this.roundControlCustomer.Size = new System.Drawing.Size(1788, 946);
            this.roundControlCustomer.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dgCustomer);
            this.panel1.Controls.Add(this.roundControl2);
            this.panel1.Location = new System.Drawing.Point(707, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1075, 892);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(457, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 31);
            this.label6.TabIndex = 58;
            this.label6.Text = "Customer List ";
            // 
            // dgCustomer
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgCustomer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgCustomer.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgCustomer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgCustomer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgCustomer.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgCustomer.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgCustomer.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgCustomer.Location = new System.Drawing.Point(23, 61);
            this.dgCustomer.Name = "dgCustomer";
            this.dgCustomer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCustomer.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgCustomer.RowHeadersWidth = 4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgCustomer.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgCustomer.RowTemplate.Height = 24;
            this.dgCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCustomer.Size = new System.Drawing.Size(1034, 806);
            this.dgCustomer.TabIndex = 1;
            this.dgCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCustomer_CellContentClick);
            this.dgCustomer.DoubleClick += new System.EventHandler(this.dgCustomer_DoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id ";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Customer Name ";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Gender ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tel ";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Address ";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // roundControl2
            // 
            this.roundControl2.BackColor = System.Drawing.Color.Gainsboro;
            this.roundControl2.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.roundControl2.BorderColor = System.Drawing.Color.Teal;
            this.roundControl2.BorderWidth = 2F;
            this.roundControl2.Location = new System.Drawing.Point(2, 2);
            this.roundControl2.Margin = new System.Windows.Forms.Padding(2);
            this.roundControl2.Name = "roundControl2";
            this.roundControl2.Radius = 30;
            this.roundControl2.Size = new System.Drawing.Size(1073, 891);
            this.roundControl2.TabIndex = 2;
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.BackColor = System.Drawing.Color.Teal;
            this.txtSearchCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchCustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCustomer.Location = new System.Drawing.Point(1506, 31);
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.Size = new System.Drawing.Size(226, 27);
            this.txtSearchCustomer.TabIndex = 59;
            this.txtSearchCustomer.TextChanged += new System.EventHandler(this.txtSearchCustomer_TextChanged_1);
            // 
            // panelCustomer
            // 
            this.panelCustomer.BackColor = System.Drawing.Color.Gainsboro;
            this.panelCustomer.Controls.Add(this.btnCustomerUpdate);
            this.panelCustomer.Controls.Add(this.roundControl7);
            this.panelCustomer.Controls.Add(this.btnDeleteCustomer);
            this.panelCustomer.Controls.Add(this.roundControl5);
            this.panelCustomer.Controls.Add(this.btnCustomerSV);
            this.panelCustomer.Controls.Add(this.cboGender);
            this.panelCustomer.Controls.Add(this.txtTel);
            this.panelCustomer.Controls.Add(this.label2);
            this.panelCustomer.Controls.Add(this.roundControl6);
            this.panelCustomer.Controls.Add(this.txtAddress);
            this.panelCustomer.Controls.Add(this.txtCustomerName);
            this.panelCustomer.Controls.Add(this.label5);
            this.panelCustomer.Controls.Add(this.label4);
            this.panelCustomer.Controls.Add(this.label3);
            this.panelCustomer.Controls.Add(this.label1);
            this.panelCustomer.Controls.Add(this.rcCusotmerInput);
            this.panelCustomer.Location = new System.Drawing.Point(47, 125);
            this.panelCustomer.Name = "panelCustomer";
            this.panelCustomer.Size = new System.Drawing.Size(657, 867);
            this.panelCustomer.TabIndex = 18;
            this.panelCustomer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCustomer_Paint);
            // 
            // btnCustomerUpdate
            // 
            this.btnCustomerUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCustomerUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCustomerUpdate.FlatAppearance.BorderSize = 0;
            this.btnCustomerUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCustomerUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCustomerUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomerUpdate.Image")));
            this.btnCustomerUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomerUpdate.Location = new System.Drawing.Point(464, 425);
            this.btnCustomerUpdate.Name = "btnCustomerUpdate";
            this.btnCustomerUpdate.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnCustomerUpdate.Size = new System.Drawing.Size(139, 35);
            this.btnCustomerUpdate.TabIndex = 56;
            this.btnCustomerUpdate.Text = "Update ";
            this.btnCustomerUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCustomerUpdate.UseVisualStyleBackColor = false;
            this.btnCustomerUpdate.Click += new System.EventHandler(this.btnCustomerUpdate_Click);
            // 
            // roundControl7
            // 
            this.roundControl7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.roundControl7.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.roundControl7.BorderColor = System.Drawing.SystemColors.Control;
            this.roundControl7.BorderWidth = 1F;
            this.roundControl7.Location = new System.Drawing.Point(435, 402);
            this.roundControl7.Margin = new System.Windows.Forms.Padding(2);
            this.roundControl7.Name = "roundControl7";
            this.roundControl7.Radius = 40;
            this.roundControl7.Size = new System.Drawing.Size(197, 80);
            this.roundControl7.TabIndex = 88;
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.BackColor = System.Drawing.Color.Red;
            this.btnDeleteCustomer.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnDeleteCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnDeleteCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnDeleteCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCustomer.Image = global::Pos_Final.Properties.Resources.ttt;
            this.btnDeleteCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteCustomer.Location = new System.Drawing.Point(258, 425);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnDeleteCustomer.Size = new System.Drawing.Size(139, 35);
            this.btnDeleteCustomer.TabIndex = 57;
            this.btnDeleteCustomer.Text = "Delete ";
            this.btnDeleteCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteCustomer.UseVisualStyleBackColor = false;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // roundControl5
            // 
            this.roundControl5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.roundControl5.BackgroundColor = System.Drawing.Color.Red;
            this.roundControl5.BorderColor = System.Drawing.SystemColors.Control;
            this.roundControl5.BorderWidth = 1F;
            this.roundControl5.Location = new System.Drawing.Point(229, 402);
            this.roundControl5.Margin = new System.Windows.Forms.Padding(2);
            this.roundControl5.Name = "roundControl5";
            this.roundControl5.Radius = 40;
            this.roundControl5.Size = new System.Drawing.Size(197, 80);
            this.roundControl5.TabIndex = 86;
            // 
            // btnCustomerSV
            // 
            this.btnCustomerSV.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCustomerSV.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCustomerSV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnCustomerSV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnCustomerSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerSV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerSV.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomerSV.Image")));
            this.btnCustomerSV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomerSV.Location = new System.Drawing.Point(55, 425);
            this.btnCustomerSV.Name = "btnCustomerSV";
            this.btnCustomerSV.Padding = new System.Windows.Forms.Padding(16, 0, 5, 0);
            this.btnCustomerSV.Size = new System.Drawing.Size(135, 35);
            this.btnCustomerSV.TabIndex = 55;
            this.btnCustomerSV.Text = "Save ";
            this.btnCustomerSV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCustomerSV.UseVisualStyleBackColor = false;
            this.btnCustomerSV.Click += new System.EventHandler(this.btnCustomerSV_Click);
            // 
            // cboGender
            // 
            this.cboGender.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "Male ",
            "Female "});
            this.cboGender.Location = new System.Drawing.Point(125, 163);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(117, 36);
            this.cboGender.TabIndex = 52;
            this.cboGender.SelectedIndexChanged += new System.EventHandler(this.cbGender_SelectedIndexChanged);
            // 
            // txtTel
            // 
            this.txtTel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(124, 220);
            this.txtTel.Multiline = true;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(263, 37);
            this.txtTel.TabIndex = 51;
            this.txtTel.TextChanged += new System.EventHandler(this.txtTelCustomer_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Address : ";
            // 
            // roundControl6
            // 
            this.roundControl6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.roundControl6.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.roundControl6.BorderColor = System.Drawing.SystemColors.Control;
            this.roundControl6.BorderWidth = 1F;
            this.roundControl6.Location = new System.Drawing.Point(24, 402);
            this.roundControl6.Margin = new System.Windows.Forms.Padding(2);
            this.roundControl6.Name = "roundControl6";
            this.roundControl6.Radius = 40;
            this.roundControl6.Size = new System.Drawing.Size(197, 80);
            this.roundControl6.TabIndex = 87;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(124, 278);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(263, 37);
            this.txtAddress.TabIndex = 50;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddressCustomer_TextChanged);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCustomerName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(124, 100);
            this.txtCustomerName.Multiline = true;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(263, 37);
            this.txtCustomerName.TabIndex = 49;
            this.txtCustomerName.TextChanged += new System.EventHandler(this.txtCustomerName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 28);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tel : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "Gender : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Customer ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rcCusotmerInput
            // 
            this.rcCusotmerInput.BackColor = System.Drawing.Color.Gainsboro;
            this.rcCusotmerInput.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.rcCusotmerInput.BorderColor = System.Drawing.Color.Teal;
            this.rcCusotmerInput.BorderWidth = 2F;
            this.rcCusotmerInput.Location = new System.Drawing.Point(0, 8);
            this.rcCusotmerInput.Margin = new System.Windows.Forms.Padding(2);
            this.rcCusotmerInput.Name = "rcCusotmerInput";
            this.rcCusotmerInput.Radius = 30;
            this.rcCusotmerInput.Size = new System.Drawing.Size(658, 565);
            this.rcCusotmerInput.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Teal;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1389, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 28);
            this.label7.TabIndex = 60;
            this.label7.Text = "Search : ";
            // 
            // roundControl1
            // 
            this.roundControl1.BackColor = System.Drawing.Color.Teal;
            this.roundControl1.BackgroundColor = System.Drawing.Color.Teal;
            this.roundControl1.BorderColor = System.Drawing.Color.Red;
            this.roundControl1.BorderWidth = 2F;
            this.roundControl1.Location = new System.Drawing.Point(1478, 12);
            this.roundControl1.Margin = new System.Windows.Forms.Padding(2);
            this.roundControl1.Name = "roundControl1";
            this.roundControl1.Radius = 30;
            this.roundControl1.Size = new System.Drawing.Size(277, 63);
            this.roundControl1.TabIndex = 61;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Teal;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(68, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(316, 38);
            this.label8.TabIndex = 62;
            this.label8.Text = "Customer Management ";
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1942, 1222);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panelCustomer);
            this.Controls.Add(this.txtSearchCustomer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.roundControlCustomer);
            this.Controls.Add(this.roundControl1);
            this.Controls.Add(this.roundControlHeaderCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomer)).EndInit();
            this.panelCustomer.ResumeLayout(false);
            this.panelCustomer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundTextBoxProject.RoundControl roundControlHeaderCustomer;
        private RoundTextBoxProject.RoundControl roundControlCustomer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgCustomer;
        private System.Windows.Forms.Panel panelCustomer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private RoundTextBoxProject.RoundControl roundControl2;
        private RoundTextBoxProject.RoundControl rcCusotmerInput;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnCustomerUpdate;
        private System.Windows.Forms.Button btnCustomerSV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearchCustomer;
        private System.Windows.Forms.Label label7;
        private RoundTextBoxProject.RoundControl roundControl1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private RoundTextBoxProject.RoundControl roundControl7;
        private RoundTextBoxProject.RoundControl roundControl5;
        private RoundTextBoxProject.RoundControl roundControl6;
    }
}