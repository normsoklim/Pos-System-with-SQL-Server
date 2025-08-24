using System;
using System.Windows.Forms;

namespace Pos_Final.views.Sales
{
    partial class SaleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSaleSearch = new System.Windows.Forms.TextBox();
            this.roundControl1 = new RoundTextBoxProject.RoundControl();
            this.roundControlHeaderSale = new RoundTextBoxProject.RoundControl();
            this.roundControlSale = new RoundTextBoxProject.RoundControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSaleDetail = new CustomControls.RJControls.RJButton();
            this.label12 = new System.Windows.Forms.Label();
            this.lblReturnKhmer = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTotalKhmer = new System.Windows.Forms.Label();
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPayment = new System.Windows.Forms.Button();
            this.roundControl5 = new RoundTextBoxProject.RoundControl();
            this.lblCashReturn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCashRecieve = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtScanbarcode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.roundControl3 = new RoundTextBoxProject.RoundControl();
            this.label3 = new System.Windows.Forms.Label();
            this.rcAmount = new RoundTextBoxProject.RoundControl();
            this.roundControlnputRoleform = new RoundTextBoxProject.RoundControl();
            this.panelControlSale = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dgSale = new System.Windows.Forms.DataGridView();
            this.roundControl2 = new RoundTextBoxProject.RoundControl();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelControlSale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Teal;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1396, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 28);
            this.label7.TabIndex = 64;
            this.label7.Text = "Search : ";
            // 
            // txtSaleSearch
            // 
            this.txtSaleSearch.BackColor = System.Drawing.Color.Teal;
            this.txtSaleSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSaleSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaleSearch.Location = new System.Drawing.Point(1508, 32);
            this.txtSaleSearch.Name = "txtSaleSearch";
            this.txtSaleSearch.Size = new System.Drawing.Size(226, 27);
            this.txtSaleSearch.TabIndex = 63;
            this.txtSaleSearch.TextChanged += new System.EventHandler(this.txtSaleSearch_TextChanged);
            // 
            // roundControl1
            // 
            this.roundControl1.BackColor = System.Drawing.Color.Teal;
            this.roundControl1.BackgroundColor = System.Drawing.Color.Teal;
            this.roundControl1.BorderColor = System.Drawing.Color.Red;
            this.roundControl1.BorderWidth = 2F;
            this.roundControl1.Location = new System.Drawing.Point(1480, 13);
            this.roundControl1.Margin = new System.Windows.Forms.Padding(2);
            this.roundControl1.Name = "roundControl1";
            this.roundControl1.Radius = 30;
            this.roundControl1.Size = new System.Drawing.Size(277, 63);
            this.roundControl1.TabIndex = 65;
            // 
            // roundControlHeaderSale
            // 
            this.roundControlHeaderSale.BackColor = System.Drawing.Color.LightGray;
            this.roundControlHeaderSale.BackgroundColor = System.Drawing.Color.Teal;
            this.roundControlHeaderSale.BorderColor = System.Drawing.SystemColors.Control;
            this.roundControlHeaderSale.BorderWidth = 1F;
            this.roundControlHeaderSale.Location = new System.Drawing.Point(11, -1);
            this.roundControlHeaderSale.Margin = new System.Windows.Forms.Padding(2);
            this.roundControlHeaderSale.Name = "roundControlHeaderSale";
            this.roundControlHeaderSale.Radius = 40;
            this.roundControlHeaderSale.Size = new System.Drawing.Size(1788, 88);
            this.roundControlHeaderSale.TabIndex = 62;
            this.roundControlHeaderSale.Load += new System.EventHandler(this.roundControlHeaderSale_Load);
            // 
            // roundControlSale
            // 
            this.roundControlSale.BackColor = System.Drawing.Color.LightGray;
            this.roundControlSale.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.roundControlSale.BorderColor = System.Drawing.Color.LightGray;
            this.roundControlSale.BorderWidth = 1F;
            this.roundControlSale.Location = new System.Drawing.Point(20, 91);
            this.roundControlSale.Margin = new System.Windows.Forms.Padding(2);
            this.roundControlSale.Name = "roundControlSale";
            this.roundControlSale.Radius = 30;
            this.roundControlSale.Size = new System.Drawing.Size(1788, 933);
            this.roundControlSale.TabIndex = 66;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnSaleDetail);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.lblReturnKhmer);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lblTotalKhmer);
            this.panel1.Controls.Add(this.cboCustomer);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnPayment);
            this.panel1.Controls.Add(this.roundControl5);
            this.panel1.Controls.Add(this.lblCashReturn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtCashRecieve);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblTotalAmount);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtScanbarcode);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.roundControl3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.rcAmount);
            this.panel1.Controls.Add(this.roundControlnputRoleform);
            this.panel1.Location = new System.Drawing.Point(1146, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(609, 882);
            this.panel1.TabIndex = 67;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(49, 749);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(154, 130);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 71;
            this.pictureBox2.TabStop = false;
            // 
            // btnSaleDetail
            // 
            this.btnSaleDetail.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSaleDetail.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.btnSaleDetail.BorderColor = System.Drawing.Color.Brown;
            this.btnSaleDetail.BorderRadius = 15;
            this.btnSaleDetail.BorderSize = 1;
            this.btnSaleDetail.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.btnSaleDetail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.btnSaleDetail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnSaleDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaleDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaleDetail.ForeColor = System.Drawing.Color.Black;
            this.btnSaleDetail.Location = new System.Drawing.Point(432, 812);
            this.btnSaleDetail.Name = "btnSaleDetail";
            this.btnSaleDetail.Size = new System.Drawing.Size(156, 54);
            this.btnSaleDetail.TabIndex = 98;
            this.btnSaleDetail.Text = "SaleDetail";
            this.btnSaleDetail.TextColor = System.Drawing.Color.Black;
            this.btnSaleDetail.UseVisualStyleBackColor = false;
            this.btnSaleDetail.Click += new System.EventHandler(this.btnSaleDetail_Click_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(374, 449);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 28);
            this.label12.TabIndex = 96;
            this.label12.Text = "|";
            // 
            // lblReturnKhmer
            // 
            this.lblReturnKhmer.AutoSize = true;
            this.lblReturnKhmer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblReturnKhmer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnKhmer.Location = new System.Drawing.Point(427, 449);
            this.lblReturnKhmer.Name = "lblReturnKhmer";
            this.lblReturnKhmer.Size = new System.Drawing.Size(100, 28);
            this.lblReturnKhmer.TabIndex = 95;
            this.lblReturnKhmer.Text = "___________";
            this.lblReturnKhmer.AutoSizeChanged += new System.EventHandler(this.lblReturnKhmer_AutoSizeChanged);
            this.lblReturnKhmer.Click += new System.EventHandler(this.lblReturnKhmer_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(375, 371);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 28);
            this.label9.TabIndex = 94;
            this.label9.Text = "|";
            // 
            // lblTotalKhmer
            // 
            this.lblTotalKhmer.AutoSize = true;
            this.lblTotalKhmer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalKhmer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalKhmer.Location = new System.Drawing.Point(420, 371);
            this.lblTotalKhmer.Name = "lblTotalKhmer";
            this.lblTotalKhmer.Size = new System.Drawing.Size(108, 28);
            this.lblTotalKhmer.TabIndex = 93;
            this.lblTotalKhmer.Text = "____________";
            // 
            // cboCustomer
            // 
            this.cboCustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(221, 264);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(229, 36);
            this.cboCustomer.TabIndex = 91;
            this.cboCustomer.SelectedIndexChanged += new System.EventHandler(this.cboCustomer_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 28);
            this.label4.TabIndex = 90;
            this.label4.Text = "CustomerName : ";
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPayment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPayment.FlatAppearance.BorderSize = 0;
            this.btnPayment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPayment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPayment.Location = new System.Drawing.Point(150, 623);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(339, 41);
            this.btnPayment.TabIndex = 81;
            this.btnPayment.Text = "Payment ";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // roundControl5
            // 
            this.roundControl5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.roundControl5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.roundControl5.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.roundControl5.BorderWidth = 1F;
            this.roundControl5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundControl5.ForeColor = System.Drawing.Color.Transparent;
            this.roundControl5.Location = new System.Drawing.Point(104, 606);
            this.roundControl5.Margin = new System.Windows.Forms.Padding(2);
            this.roundControl5.Name = "roundControl5";
            this.roundControl5.Radius = 30;
            this.roundControl5.Size = new System.Drawing.Size(423, 74);
            this.roundControl5.TabIndex = 82;
            this.roundControl5.Load += new System.EventHandler(this.roundControl5_Load);
            // 
            // lblCashReturn
            // 
            this.lblCashReturn.AutoSize = true;
            this.lblCashReturn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCashReturn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashReturn.Location = new System.Drawing.Point(233, 449);
            this.lblCashReturn.Name = "lblCashReturn";
            this.lblCashReturn.Size = new System.Drawing.Size(100, 28);
            this.lblCashReturn.TabIndex = 80;
            this.lblCashReturn.Text = "___________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 449);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 28);
            this.label1.TabIndex = 79;
            this.label1.Text = "Cash Return : ";
            // 
            // txtCashRecieve
            // 
            this.txtCashRecieve.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCashRecieve.Location = new System.Drawing.Point(221, 183);
            this.txtCashRecieve.Multiline = true;
            this.txtCashRecieve.Name = "txtCashRecieve";
            this.txtCashRecieve.Size = new System.Drawing.Size(289, 35);
            this.txtCashRecieve.TabIndex = 78;
            this.txtCashRecieve.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCashRecieve_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 28);
            this.label2.TabIndex = 77;
            this.label2.Text = "Cash Recieve : ";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(234, 371);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(108, 28);
            this.lblTotalAmount.TabIndex = 76;
            this.lblTotalAmount.Text = "____________";
            this.lblTotalAmount.Click += new System.EventHandler(this.lblTotalAmount_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(70, 371);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 28);
            this.label10.TabIndex = 75;
            this.label10.Text = "Total Amount : ";
            // 
            // txtScanbarcode
            // 
            this.txtScanbarcode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScanbarcode.Location = new System.Drawing.Point(221, 96);
            this.txtScanbarcode.Multiline = true;
            this.txtScanbarcode.Name = "txtScanbarcode";
            this.txtScanbarcode.Size = new System.Drawing.Size(289, 35);
            this.txtScanbarcode.TabIndex = 74;
            this.txtScanbarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtScanbarcode_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(52, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 28);
            this.label8.TabIndex = 73;
            this.label8.Text = "Scan-Barcode :  ";
            // 
            // roundControl3
            // 
            this.roundControl3.BackColor = System.Drawing.Color.Gainsboro;
            this.roundControl3.BackgroundColor = System.Drawing.Color.Teal;
            this.roundControl3.BorderColor = System.Drawing.SystemColors.Control;
            this.roundControl3.BorderWidth = 1F;
            this.roundControl3.Location = new System.Drawing.Point(-10, -28);
            this.roundControl3.Margin = new System.Windows.Forms.Padding(2);
            this.roundControl3.Name = "roundControl3";
            this.roundControl3.Radius = 10;
            this.roundControl3.Size = new System.Drawing.Size(29, 973);
            this.roundControl3.TabIndex = 70;
            this.roundControl3.Load += new System.EventHandler(this.roundControl3_Load);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(271, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 28);
            this.label3.TabIndex = 55;
            this.label3.Text = "Input Sale ";
            // 
            // rcAmount
            // 
            this.rcAmount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rcAmount.BackgroundColor = System.Drawing.Color.Transparent;
            this.rcAmount.BorderColor = System.Drawing.Color.Red;
            this.rcAmount.BorderWidth = 1F;
            this.rcAmount.Location = new System.Drawing.Point(42, 339);
            this.rcAmount.Margin = new System.Windows.Forms.Padding(2);
            this.rcAmount.Name = "rcAmount";
            this.rcAmount.Radius = 30;
            this.rcAmount.Size = new System.Drawing.Size(546, 221);
            this.rcAmount.TabIndex = 97;
            // 
            // roundControlnputRoleform
            // 
            this.roundControlnputRoleform.BackColor = System.Drawing.Color.Transparent;
            this.roundControlnputRoleform.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.roundControlnputRoleform.BorderColor = System.Drawing.Color.Teal;
            this.roundControlnputRoleform.BorderWidth = 2F;
            this.roundControlnputRoleform.Location = new System.Drawing.Point(19, 12);
            this.roundControlnputRoleform.Margin = new System.Windows.Forms.Padding(2);
            this.roundControlnputRoleform.Name = "roundControlnputRoleform";
            this.roundControlnputRoleform.Radius = 30;
            this.roundControlnputRoleform.Size = new System.Drawing.Size(589, 741);
            this.roundControlnputRoleform.TabIndex = 50;
            this.roundControlnputRoleform.Load += new System.EventHandler(this.roundControlnputRoleform_Load);
            // 
            // panelControlSale
            // 
            this.panelControlSale.BackColor = System.Drawing.Color.Gainsboro;
            this.panelControlSale.Controls.Add(this.label5);
            this.panelControlSale.Controls.Add(this.dgSale);
            this.panelControlSale.Controls.Add(this.roundControl2);
            this.panelControlSale.Location = new System.Drawing.Point(36, 121);
            this.panelControlSale.Name = "panelControlSale";
            this.panelControlSale.Size = new System.Drawing.Size(1106, 870);
            this.panelControlSale.TabIndex = 68;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(493, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 31);
            this.label5.TabIndex = 13;
            this.label5.Text = "Sale List  ";
            // 
            // dgSale
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgSale.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgSale.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgSale.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgSale.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgSale.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgSale.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgSale.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgSale.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgSale.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgSale.Location = new System.Drawing.Point(26, 61);
            this.dgSale.Name = "dgSale";
            this.dgSale.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgSale.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgSale.RowHeadersWidth = 4;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgSale.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgSale.RowTemplate.Height = 24;
            this.dgSale.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSale.Size = new System.Drawing.Size(1044, 774);
            this.dgSale.TabIndex = 11;
            this.dgSale.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSales_CellContentClick);
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
            this.roundControl2.Size = new System.Drawing.Size(1091, 866);
            this.roundControl2.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Teal;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(789, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 38);
            this.label6.TabIndex = 69;
            this.label6.Text = "Sale Managment ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Teal;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(82, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ProductId";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 6;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Barcode";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 6;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Description";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Qty";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column5.HeaderText = "Price";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 200;
            // 
            // Column6
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column6.HeaderText = "Total";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 250;
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1942, 1222);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panelControlSale);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.roundControlSale);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSaleSearch);
            this.Controls.Add(this.roundControl1);
            this.Controls.Add(this.roundControlHeaderSale);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SaleForm";
            this.Text = "SaleForm";
            this.Load += new System.EventHandler(this.SaleForm_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelControlSale.ResumeLayout(false);
            this.panelControlSale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSaleSearch;
        private RoundTextBoxProject.RoundControl roundControl1;
        private RoundTextBoxProject.RoundControl roundControlHeaderSale;
        private RoundTextBoxProject.RoundControl roundControlSale;
        private System.Windows.Forms.Panel panel1;
        private RoundTextBoxProject.RoundControl roundControlnputRoleform;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelControlSale;
        private System.Windows.Forms.DataGridView dgSale;
        private RoundTextBoxProject.RoundControl roundControl2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private RoundTextBoxProject.RoundControl roundControl3;
        private Label lblCashReturn;
        private Label label1;
        private TextBox txtCashRecieve;
        private Label label2;
        private Label lblTotalAmount;
        private Label label10;
        private TextBox txtScanbarcode;
        private Label label8;
        private Button btnPayment;
        private RoundTextBoxProject.RoundControl roundControl5;
        private ComboBox cboCustomer;
        private Label label4;
        private PictureBox pictureBox1;
        private Label lblTotalKhmer;
        private Label label9;
        private Label label12;
        private Label lblReturnKhmer;
        private RoundTextBoxProject.RoundControl rcAmount;
        private CustomControls.RJControls.RJButton btnSaleDetail;
        private PictureBox pictureBox2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}