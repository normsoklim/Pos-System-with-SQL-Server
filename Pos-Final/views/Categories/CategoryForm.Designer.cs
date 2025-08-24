namespace Pos_Final.views.Products
{
    partial class CategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.roundControlCategory = new RoundTextBoxProject.RoundControl();
            this.label3 = new System.Windows.Forms.Label();
            this.roundControlHeaderUserRole = new RoundTextBoxProject.RoundControl();
            this.panelInputCategory = new System.Windows.Forms.Panel();
            this.rTrue = new System.Windows.Forms.RadioButton();
            this.rFalse = new System.Windows.Forms.RadioButton();
            this.btnUpdateCategory = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnSaveCategory = new System.Windows.Forms.Button();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.roundControl7 = new RoundTextBoxProject.RoundControl();
            this.roundControl3 = new RoundTextBoxProject.RoundControl();
            this.roundControl1 = new RoundTextBoxProject.RoundControl();
            this.rcInputCategory = new RoundTextBoxProject.RoundControl();
            this.panelCategoryList = new System.Windows.Forms.Panel();
            this.dgCategory = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rCCateogryList = new RoundTextBoxProject.RoundControl();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearchCategory = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.roundControl2 = new RoundTextBoxProject.RoundControl();
            this.panelInputCategory.SuspendLayout();
            this.panelCategoryList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // roundControlCategory
            // 
            this.roundControlCategory.BackColor = System.Drawing.Color.Transparent;
            this.roundControlCategory.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.roundControlCategory.BorderColor = System.Drawing.SystemColors.Control;
            this.roundControlCategory.BorderWidth = 1F;
            this.roundControlCategory.Location = new System.Drawing.Point(11, 81);
            this.roundControlCategory.Margin = new System.Windows.Forms.Padding(2);
            this.roundControlCategory.Name = "roundControlCategory";
            this.roundControlCategory.Radius = 30;
            this.roundControlCategory.Size = new System.Drawing.Size(1788, 928);
            this.roundControlCategory.TabIndex = 0;
            this.roundControlCategory.Load += new System.EventHandler(this.roundControl1_Load);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Teal;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(308, 38);
            this.label3.TabIndex = 12;
            this.label3.Text = "Category Management ";
            // 
            // roundControlHeaderUserRole
            // 
            this.roundControlHeaderUserRole.BackColor = System.Drawing.Color.LightGray;
            this.roundControlHeaderUserRole.BackgroundColor = System.Drawing.Color.Teal;
            this.roundControlHeaderUserRole.BorderColor = System.Drawing.SystemColors.Control;
            this.roundControlHeaderUserRole.BorderWidth = 1F;
            this.roundControlHeaderUserRole.Location = new System.Drawing.Point(11, -1);
            this.roundControlHeaderUserRole.Margin = new System.Windows.Forms.Padding(2);
            this.roundControlHeaderUserRole.Name = "roundControlHeaderUserRole";
            this.roundControlHeaderUserRole.Radius = 40;
            this.roundControlHeaderUserRole.Size = new System.Drawing.Size(1788, 88);
            this.roundControlHeaderUserRole.TabIndex = 13;
            this.roundControlHeaderUserRole.Load += new System.EventHandler(this.roundControlHeaderUserRole_Load);
            // 
            // panelInputCategory
            // 
            this.panelInputCategory.BackColor = System.Drawing.Color.Gainsboro;
            this.panelInputCategory.Controls.Add(this.rTrue);
            this.panelInputCategory.Controls.Add(this.rFalse);
            this.panelInputCategory.Controls.Add(this.btnUpdateCategory);
            this.panelInputCategory.Controls.Add(this.btnDeleteCategory);
            this.panelInputCategory.Controls.Add(this.btnSaveCategory);
            this.panelInputCategory.Controls.Add(this.txtCategoryName);
            this.panelInputCategory.Controls.Add(this.label6);
            this.panelInputCategory.Controls.Add(this.label2);
            this.panelInputCategory.Controls.Add(this.label1);
            this.panelInputCategory.Controls.Add(this.roundControl7);
            this.panelInputCategory.Controls.Add(this.roundControl3);
            this.panelInputCategory.Controls.Add(this.roundControl1);
            this.panelInputCategory.Controls.Add(this.rcInputCategory);
            this.panelInputCategory.Location = new System.Drawing.Point(25, 122);
            this.panelInputCategory.Name = "panelInputCategory";
            this.panelInputCategory.Size = new System.Drawing.Size(603, 861);
            this.panelInputCategory.TabIndex = 14;
            this.panelInputCategory.Paint += new System.Windows.Forms.PaintEventHandler(this.panelInputCategory_Paint);
            // 
            // rTrue
            // 
            this.rTrue.AutoSize = true;
            this.rTrue.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rTrue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTrue.Location = new System.Drawing.Point(179, 227);
            this.rTrue.Name = "rTrue";
            this.rTrue.Size = new System.Drawing.Size(74, 32);
            this.rTrue.TabIndex = 90;
            this.rTrue.TabStop = true;
            this.rTrue.Text = "True ";
            this.rTrue.UseVisualStyleBackColor = false;
            this.rTrue.CheckedChanged += new System.EventHandler(this.rTrue_CheckedChanged);
            // 
            // rFalse
            // 
            this.rFalse.AutoSize = true;
            this.rFalse.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rFalse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rFalse.Location = new System.Drawing.Point(283, 227);
            this.rFalse.Name = "rFalse";
            this.rFalse.Size = new System.Drawing.Size(80, 32);
            this.rFalse.TabIndex = 91;
            this.rFalse.TabStop = true;
            this.rFalse.Text = "False ";
            this.rFalse.UseVisualStyleBackColor = false;
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUpdateCategory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUpdateCategory.FlatAppearance.BorderSize = 0;
            this.btnUpdateCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUpdateCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUpdateCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateCategory.Image")));
            this.btnUpdateCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateCategory.Location = new System.Drawing.Point(404, 302);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnUpdateCategory.Size = new System.Drawing.Size(139, 43);
            this.btnUpdateCategory.TabIndex = 45;
            this.btnUpdateCategory.Text = "Update ";
            this.btnUpdateCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateCategory.UseVisualStyleBackColor = false;
            this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.BackColor = System.Drawing.Color.Red;
            this.btnDeleteCategory.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnDeleteCategory.FlatAppearance.BorderSize = 0;
            this.btnDeleteCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnDeleteCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnDeleteCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteCategory.Image")));
            this.btnDeleteCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteCategory.Location = new System.Drawing.Point(241, 378);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnDeleteCategory.Size = new System.Drawing.Size(139, 44);
            this.btnDeleteCategory.TabIndex = 44;
            this.btnDeleteCategory.Text = "Delete ";
            this.btnDeleteCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteCategory.UseVisualStyleBackColor = false;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnSaveCategory
            // 
            this.btnSaveCategory.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveCategory.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveCategory.FlatAppearance.BorderSize = 0;
            this.btnSaveCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveCategory.Image")));
            this.btnSaveCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveCategory.Location = new System.Drawing.Point(98, 302);
            this.btnSaveCategory.Name = "btnSaveCategory";
            this.btnSaveCategory.Padding = new System.Windows.Forms.Padding(16, 0, 5, 0);
            this.btnSaveCategory.Size = new System.Drawing.Size(135, 43);
            this.btnSaveCategory.TabIndex = 43;
            this.btnSaveCategory.Text = "Save ";
            this.btnSaveCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveCategory.UseVisualStyleBackColor = false;
            this.btnSaveCategory.Click += new System.EventHandler(this.btnSaveCategory_Click);
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCategoryName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryName.Location = new System.Drawing.Point(177, 153);
            this.txtCategoryName.Multiline = true;
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(263, 37);
            this.txtCategoryName.TabIndex = 41;
            this.txtCategoryName.TextChanged += new System.EventHandler(this.txtNameCategory_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Gainsboro;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(227, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 31);
            this.label6.TabIndex = 4;
            this.label6.Text = "Input Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Status ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // roundControl7
            // 
            this.roundControl7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.roundControl7.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.roundControl7.BorderColor = System.Drawing.SystemColors.Control;
            this.roundControl7.BorderWidth = 1F;
            this.roundControl7.Location = new System.Drawing.Point(67, 283);
            this.roundControl7.Margin = new System.Windows.Forms.Padding(2);
            this.roundControl7.Name = "roundControl7";
            this.roundControl7.Radius = 40;
            this.roundControl7.Size = new System.Drawing.Size(197, 80);
            this.roundControl7.TabIndex = 83;
            // 
            // roundControl3
            // 
            this.roundControl3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.roundControl3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.roundControl3.BorderColor = System.Drawing.SystemColors.Control;
            this.roundControl3.BorderWidth = 1F;
            this.roundControl3.Location = new System.Drawing.Point(375, 283);
            this.roundControl3.Margin = new System.Windows.Forms.Padding(2);
            this.roundControl3.Name = "roundControl3";
            this.roundControl3.Radius = 40;
            this.roundControl3.Size = new System.Drawing.Size(197, 80);
            this.roundControl3.TabIndex = 85;
            // 
            // roundControl1
            // 
            this.roundControl1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.roundControl1.BackgroundColor = System.Drawing.Color.Red;
            this.roundControl1.BorderColor = System.Drawing.SystemColors.Control;
            this.roundControl1.BorderWidth = 1F;
            this.roundControl1.Location = new System.Drawing.Point(212, 360);
            this.roundControl1.Margin = new System.Windows.Forms.Padding(2);
            this.roundControl1.Name = "roundControl1";
            this.roundControl1.Radius = 40;
            this.roundControl1.Size = new System.Drawing.Size(197, 80);
            this.roundControl1.TabIndex = 84;
            // 
            // rcInputCategory
            // 
            this.rcInputCategory.BackColor = System.Drawing.Color.Gainsboro;
            this.rcInputCategory.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.rcInputCategory.BorderColor = System.Drawing.Color.Teal;
            this.rcInputCategory.BorderWidth = 2F;
            this.rcInputCategory.ForeColor = System.Drawing.Color.Black;
            this.rcInputCategory.Location = new System.Drawing.Point(25, 48);
            this.rcInputCategory.Margin = new System.Windows.Forms.Padding(2);
            this.rcInputCategory.Name = "rcInputCategory";
            this.rcInputCategory.Radius = 30;
            this.rcInputCategory.Size = new System.Drawing.Size(570, 418);
            this.rcInputCategory.TabIndex = 5;
            this.rcInputCategory.Load += new System.EventHandler(this.rcInputCategory_Load);
            // 
            // panelCategoryList
            // 
            this.panelCategoryList.BackColor = System.Drawing.Color.Gainsboro;
            this.panelCategoryList.Controls.Add(this.dgCategory);
            this.panelCategoryList.Controls.Add(this.rCCateogryList);
            this.panelCategoryList.Controls.Add(this.label5);
            this.panelCategoryList.Location = new System.Drawing.Point(634, 122);
            this.panelCategoryList.Name = "panelCategoryList";
            this.panelCategoryList.Size = new System.Drawing.Size(1143, 863);
            this.panelCategoryList.TabIndex = 15;
            this.panelCategoryList.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCategoryList_Paint);
            // 
            // dgCategory
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgCategory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgCategory.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgCategory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgCategory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgCategory.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgCategory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgCategory.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgCategory.Location = new System.Drawing.Point(58, 83);
            this.dgCategory.Name = "dgCategory";
            this.dgCategory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCategory.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgCategory.RowHeadersWidth = 4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgCategory.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgCategory.RowTemplate.Height = 24;
            this.dgCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCategory.Size = new System.Drawing.Size(1063, 748);
            this.dgCategory.TabIndex = 5;
            this.dgCategory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCategory_CellContentClick);
            this.dgCategory.DoubleClick += new System.EventHandler(this.dgCategory_DoubleClick_1);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id ";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Category Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 300;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Status ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 250;
            // 
            // rCCateogryList
            // 
            this.rCCateogryList.BackColor = System.Drawing.Color.Gainsboro;
            this.rCCateogryList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.rCCateogryList.BorderColor = System.Drawing.Color.Teal;
            this.rCCateogryList.BorderWidth = 2F;
            this.rCCateogryList.Location = new System.Drawing.Point(33, 48);
            this.rCCateogryList.Margin = new System.Windows.Forms.Padding(2);
            this.rCCateogryList.Name = "rCCateogryList";
            this.rCCateogryList.Radius = 30;
            this.rCCateogryList.Size = new System.Drawing.Size(1108, 813);
            this.rCCateogryList.TabIndex = 4;
            this.rCCateogryList.Load += new System.EventHandler(this.rCCateogryList_Load);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(514, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 31);
            this.label5.TabIndex = 3;
            this.label5.Text = "Category List";
            // 
            // txtSearchCategory
            // 
            this.txtSearchCategory.BackColor = System.Drawing.Color.Teal;
            this.txtSearchCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchCategory.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCategory.ForeColor = System.Drawing.Color.Black;
            this.txtSearchCategory.Location = new System.Drawing.Point(1510, 31);
            this.txtSearchCategory.Multiline = true;
            this.txtSearchCategory.Name = "txtSearchCategory";
            this.txtSearchCategory.Size = new System.Drawing.Size(222, 28);
            this.txtSearchCategory.TabIndex = 46;
            this.txtSearchCategory.TextChanged += new System.EventHandler(this.txtSearchCategory_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Teal;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1398, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 28);
            this.label8.TabIndex = 47;
            this.label8.Text = "Search :";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // roundControl2
            // 
            this.roundControl2.BackColor = System.Drawing.Color.Teal;
            this.roundControl2.BackgroundColor = System.Drawing.Color.Teal;
            this.roundControl2.BorderColor = System.Drawing.Color.Red;
            this.roundControl2.BorderWidth = 2F;
            this.roundControl2.Location = new System.Drawing.Point(1482, 12);
            this.roundControl2.Margin = new System.Windows.Forms.Padding(2);
            this.roundControl2.Name = "roundControl2";
            this.roundControl2.Radius = 30;
            this.roundControl2.Size = new System.Drawing.Size(277, 63);
            this.roundControl2.TabIndex = 66;
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1942, 1222);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSearchCategory);
            this.Controls.Add(this.roundControl2);
            this.Controls.Add(this.panelCategoryList);
            this.Controls.Add(this.panelInputCategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.roundControlHeaderUserRole);
            this.Controls.Add(this.roundControlCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoryForm";
            this.Text = "CategoryForm";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            this.panelInputCategory.ResumeLayout(false);
            this.panelInputCategory.PerformLayout();
            this.panelCategoryList.ResumeLayout(false);
            this.panelCategoryList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundTextBoxProject.RoundControl roundControlCategory;
        private System.Windows.Forms.Label label3;
        private RoundTextBoxProject.RoundControl roundControlHeaderUserRole;
        private System.Windows.Forms.Panel panelInputCategory;
        private System.Windows.Forms.Panel panelCategoryList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private RoundTextBoxProject.RoundControl rcInputCategory;
        private RoundTextBoxProject.RoundControl rCCateogryList;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.DataGridView dgCategory;
        private System.Windows.Forms.Button btnUpdateCategory;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnSaveCategory;
        private System.Windows.Forms.TextBox txtSearchCategory;
        private System.Windows.Forms.Label label8;
        private RoundTextBoxProject.RoundControl roundControl2;
        private RoundTextBoxProject.RoundControl roundControl7;
        private RoundTextBoxProject.RoundControl roundControl3;
        private RoundTextBoxProject.RoundControl roundControl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.RadioButton rTrue;
        private System.Windows.Forms.RadioButton rFalse;
    }
}