using System;

namespace Pos_Final.views.UserRoles
{
    partial class UserRoleForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRoleForm));
            this.txtSearchUserRole = new System.Windows.Forms.TextBox();
            this.SearchUserRole = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgUserRole = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roundControlHeaderUserRole = new RoundTextBoxProject.RoundControl();
            this.roundControlUserRole = new RoundTextBoxProject.RoundControl();
            this.RoleId = new System.Windows.Forms.Label();
            this.UserId = new System.Windows.Forms.Label();
            this.ControlpanelUserRoleInput = new System.Windows.Forms.Panel();
            this.roundControl3 = new RoundTextBoxProject.RoundControl();
            this.cboRole = new System.Windows.Forms.ComboBox();
            this.cboUser = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUpdateuser = new System.Windows.Forms.Button();
            this.btnDeleteuser = new System.Windows.Forms.Button();
            this.btnSaveAllUser = new System.Windows.Forms.Button();
            this.roundControl8 = new RoundTextBoxProject.RoundControl();
            this.roundControl9 = new RoundTextBoxProject.RoundControl();
            this.roundControl7 = new RoundTextBoxProject.RoundControl();
            this.roundControlinterface = new RoundTextBoxProject.RoundControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ControlPanelUserList10 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.roundControl2 = new RoundTextBoxProject.RoundControl();
            this.roundControl1 = new RoundTextBoxProject.RoundControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picUserList = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgUserRole)).BeginInit();
            this.ControlpanelUserRoleInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchUserRole
            // 
            this.txtSearchUserRole.BackColor = System.Drawing.Color.Teal;
            this.txtSearchUserRole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchUserRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchUserRole.Location = new System.Drawing.Point(1508, 29);
            this.txtSearchUserRole.Multiline = true;
            this.txtSearchUserRole.Name = "txtSearchUserRole";
            this.txtSearchUserRole.Size = new System.Drawing.Size(226, 32);
            this.txtSearchUserRole.TabIndex = 4;
            this.txtSearchUserRole.TextChanged += new System.EventHandler(this.txtSearchUserRole_TextChanged);
            // 
            // SearchUserRole
            // 
            this.SearchUserRole.AutoSize = true;
            this.SearchUserRole.BackColor = System.Drawing.Color.Teal;
            this.SearchUserRole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchUserRole.Location = new System.Drawing.Point(1391, 27);
            this.SearchUserRole.Name = "SearchUserRole";
            this.SearchUserRole.Size = new System.Drawing.Size(84, 28);
            this.SearchUserRole.TabIndex = 5;
            this.SearchUserRole.Text = "Search  :";
            this.SearchUserRole.Click += new System.EventHandler(this.SearchUserRole_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Teal;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(147, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(299, 38);
            this.label3.TabIndex = 6;
            this.label3.Text = "UserRole Management";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dgUserRole
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgUserRole.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgUserRole.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgUserRole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgUserRole.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgUserRole.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgUserRole.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgUserRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUserRole.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column1,
            this.Column2});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgUserRole.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgUserRole.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgUserRole.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgUserRole.Location = new System.Drawing.Point(87, 534);
            this.dgUserRole.Name = "dgUserRole";
            this.dgUserRole.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgUserRole.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgUserRole.RowHeadersWidth = 4;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgUserRole.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgUserRole.RowTemplate.Height = 24;
            this.dgUserRole.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgUserRole.Size = new System.Drawing.Size(1076, 470);
            this.dgUserRole.TabIndex = 10;
            this.dgUserRole.DoubleClick += new System.EventHandler(this.dgUserRole_DoubleClick);
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Id";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column1
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column1.HeaderText = "UserId ";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 250;
            // 
            // Column2
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column2.HeaderText = "RoleId";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 250;
            // 
            // roundControlHeaderUserRole
            // 
            this.roundControlHeaderUserRole.BackColor = System.Drawing.Color.Transparent;
            this.roundControlHeaderUserRole.BackgroundColor = System.Drawing.Color.Teal;
            this.roundControlHeaderUserRole.BorderColor = System.Drawing.SystemColors.Control;
            this.roundControlHeaderUserRole.BorderWidth = 1F;
            this.roundControlHeaderUserRole.Location = new System.Drawing.Point(11, -1);
            this.roundControlHeaderUserRole.Margin = new System.Windows.Forms.Padding(2);
            this.roundControlHeaderUserRole.Name = "roundControlHeaderUserRole";
            this.roundControlHeaderUserRole.Radius = 40;
            this.roundControlHeaderUserRole.Size = new System.Drawing.Size(1788, 88);
            this.roundControlHeaderUserRole.TabIndex = 11;
            this.roundControlHeaderUserRole.Load += new System.EventHandler(this.roundControlHeaderUserRole_Load);
            // 
            // roundControlUserRole
            // 
            this.roundControlUserRole.BackColor = System.Drawing.Color.Transparent;
            this.roundControlUserRole.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.roundControlUserRole.BorderColor = System.Drawing.SystemColors.Control;
            this.roundControlUserRole.BorderWidth = 1F;
            this.roundControlUserRole.Location = new System.Drawing.Point(11, 81);
            this.roundControlUserRole.Margin = new System.Windows.Forms.Padding(2);
            this.roundControlUserRole.Name = "roundControlUserRole";
            this.roundControlUserRole.Radius = 30;
            this.roundControlUserRole.Size = new System.Drawing.Size(1788, 977);
            this.roundControlUserRole.TabIndex = 12;
            this.roundControlUserRole.Load += new System.EventHandler(this.roundControlUserRole_Load);
            // 
            // RoleId
            // 
            this.RoleId.AutoSize = true;
            this.RoleId.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RoleId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleId.Location = new System.Drawing.Point(80, 166);
            this.RoleId.Name = "RoleId";
            this.RoleId.Size = new System.Drawing.Size(67, 28);
            this.RoleId.TabIndex = 19;
            this.RoleId.Text = "RoleId";
            this.RoleId.Click += new System.EventHandler(this.RoleId_Click_1);
            // 
            // UserId
            // 
            this.UserId.AutoSize = true;
            this.UserId.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UserId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserId.Location = new System.Drawing.Point(79, 77);
            this.UserId.Name = "UserId";
            this.UserId.Size = new System.Drawing.Size(68, 28);
            this.UserId.TabIndex = 18;
            this.UserId.Text = "UserId";
            this.UserId.Click += new System.EventHandler(this.UserId_Click);
            // 
            // ControlpanelUserRoleInput
            // 
            this.ControlpanelUserRoleInput.BackColor = System.Drawing.Color.Gainsboro;
            this.ControlpanelUserRoleInput.Controls.Add(this.roundControl3);
            this.ControlpanelUserRoleInput.Controls.Add(this.cboRole);
            this.ControlpanelUserRoleInput.Controls.Add(this.cboUser);
            this.ControlpanelUserRoleInput.Controls.Add(this.label4);
            this.ControlpanelUserRoleInput.Controls.Add(this.UserId);
            this.ControlpanelUserRoleInput.Controls.Add(this.RoleId);
            this.ControlpanelUserRoleInput.Controls.Add(this.btnUpdateuser);
            this.ControlpanelUserRoleInput.Controls.Add(this.btnDeleteuser);
            this.ControlpanelUserRoleInput.Controls.Add(this.btnSaveAllUser);
            this.ControlpanelUserRoleInput.Controls.Add(this.roundControl8);
            this.ControlpanelUserRoleInput.Controls.Add(this.roundControl9);
            this.ControlpanelUserRoleInput.Controls.Add(this.roundControl7);
            this.ControlpanelUserRoleInput.Controls.Add(this.roundControlinterface);
            this.ControlpanelUserRoleInput.Location = new System.Drawing.Point(36, 103);
            this.ControlpanelUserRoleInput.Name = "ControlpanelUserRoleInput";
            this.ControlpanelUserRoleInput.Size = new System.Drawing.Size(1740, 355);
            this.ControlpanelUserRoleInput.TabIndex = 30;
            this.ControlpanelUserRoleInput.Paint += new System.Windows.Forms.PaintEventHandler(this.ControlpanelInputUserRole_Paint);
            // 
            // roundControl3
            // 
            this.roundControl3.BackColor = System.Drawing.Color.Gainsboro;
            this.roundControl3.BackgroundColor = System.Drawing.Color.Teal;
            this.roundControl3.BorderColor = System.Drawing.SystemColors.Control;
            this.roundControl3.BorderWidth = 1F;
            this.roundControl3.Location = new System.Drawing.Point(-19, 341);
            this.roundControl3.Margin = new System.Windows.Forms.Padding(2);
            this.roundControl3.Name = "roundControl3";
            this.roundControl3.Radius = 10;
            this.roundControl3.Size = new System.Drawing.Size(1766, 14);
            this.roundControl3.TabIndex = 40;
            // 
            // cboRole
            // 
            this.cboRole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRole.Location = new System.Drawing.Point(165, 163);
            this.cboRole.Name = "cboRole";
            this.cboRole.Size = new System.Drawing.Size(229, 36);
            this.cboRole.TabIndex = 0;
            this.cboRole.SelectedIndexChanged += new System.EventHandler(this.cbRoleId_SelectedIndexChanged_1);
            // 
            // cboUser
            // 
            this.cboUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUser.Location = new System.Drawing.Point(165, 77);
            this.cboUser.Name = "cboUser";
            this.cboUser.Size = new System.Drawing.Size(229, 36);
            this.cboUser.TabIndex = 1;
            this.cboUser.SelectedIndexChanged += new System.EventHandler(this.cbUserId_SelectedIndexChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(815, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 31);
            this.label4.TabIndex = 32;
            this.label4.Text = "UserRole ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnUpdateuser
            // 
            this.btnUpdateuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUpdateuser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUpdateuser.FlatAppearance.BorderSize = 0;
            this.btnUpdateuser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUpdateuser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUpdateuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateuser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateuser.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateuser.Image")));
            this.btnUpdateuser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateuser.Location = new System.Drawing.Point(1255, 259);
            this.btnUpdateuser.Name = "btnUpdateuser";
            this.btnUpdateuser.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnUpdateuser.Size = new System.Drawing.Size(163, 35);
            this.btnUpdateuser.TabIndex = 34;
            this.btnUpdateuser.Text = "Update ";
            this.btnUpdateuser.UseVisualStyleBackColor = false;
            this.btnUpdateuser.Click += new System.EventHandler(this.btnUpdateuser_Click);
            // 
            // btnDeleteuser
            // 
            this.btnDeleteuser.BackColor = System.Drawing.Color.Red;
            this.btnDeleteuser.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnDeleteuser.FlatAppearance.BorderSize = 0;
            this.btnDeleteuser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnDeleteuser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnDeleteuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteuser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteuser.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteuser.Image")));
            this.btnDeleteuser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteuser.Location = new System.Drawing.Point(1489, 259);
            this.btnDeleteuser.Name = "btnDeleteuser";
            this.btnDeleteuser.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnDeleteuser.Size = new System.Drawing.Size(146, 35);
            this.btnDeleteuser.TabIndex = 33;
            this.btnDeleteuser.Text = "Delete";
            this.btnDeleteuser.UseVisualStyleBackColor = false;
            this.btnDeleteuser.Click += new System.EventHandler(this.btnDeleteuser_Click);
            // 
            // btnSaveAllUser
            // 
            this.btnSaveAllUser.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveAllUser.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveAllUser.FlatAppearance.BorderSize = 0;
            this.btnSaveAllUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveAllUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveAllUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAllUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAllUser.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveAllUser.Image")));
            this.btnSaveAllUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveAllUser.Location = new System.Drawing.Point(175, 259);
            this.btnSaveAllUser.Name = "btnSaveAllUser";
            this.btnSaveAllUser.Padding = new System.Windows.Forms.Padding(16, 0, 2, 0);
            this.btnSaveAllUser.Size = new System.Drawing.Size(135, 35);
            this.btnSaveAllUser.TabIndex = 32;
            this.btnSaveAllUser.Text = "Save ";
            this.btnSaveAllUser.UseVisualStyleBackColor = false;
            this.btnSaveAllUser.Click += new System.EventHandler(this.btnSaveAllUser_Click);
            // 
            // roundControl8
            // 
            this.roundControl8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.roundControl8.BackgroundColor = System.Drawing.Color.Red;
            this.roundControl8.BorderColor = System.Drawing.SystemColors.Control;
            this.roundControl8.BorderWidth = 1F;
            this.roundControl8.Location = new System.Drawing.Point(1456, 236);
            this.roundControl8.Margin = new System.Windows.Forms.Padding(2);
            this.roundControl8.Name = "roundControl8";
            this.roundControl8.Radius = 40;
            this.roundControl8.Size = new System.Drawing.Size(205, 80);
            this.roundControl8.TabIndex = 83;
            // 
            // roundControl9
            // 
            this.roundControl9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.roundControl9.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.roundControl9.BorderColor = System.Drawing.SystemColors.Control;
            this.roundControl9.BorderWidth = 1F;
            this.roundControl9.Location = new System.Drawing.Point(1227, 236);
            this.roundControl9.Margin = new System.Windows.Forms.Padding(2);
            this.roundControl9.Name = "roundControl9";
            this.roundControl9.Radius = 40;
            this.roundControl9.Size = new System.Drawing.Size(212, 80);
            this.roundControl9.TabIndex = 84;
            // 
            // roundControl7
            // 
            this.roundControl7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.roundControl7.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.roundControl7.BorderColor = System.Drawing.SystemColors.Control;
            this.roundControl7.BorderWidth = 1F;
            this.roundControl7.Location = new System.Drawing.Point(144, 236);
            this.roundControl7.Margin = new System.Windows.Forms.Padding(2);
            this.roundControl7.Name = "roundControl7";
            this.roundControl7.Radius = 40;
            this.roundControl7.Size = new System.Drawing.Size(193, 80);
            this.roundControl7.TabIndex = 82;
            // 
            // roundControlinterface
            // 
            this.roundControlinterface.BackColor = System.Drawing.Color.Transparent;
            this.roundControlinterface.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.roundControlinterface.BorderColor = System.Drawing.Color.Teal;
            this.roundControlinterface.BorderWidth = 2F;
            this.roundControlinterface.Location = new System.Drawing.Point(20, 19);
            this.roundControlinterface.Margin = new System.Windows.Forms.Padding(2);
            this.roundControlinterface.Name = "roundControlinterface";
            this.roundControlinterface.Radius = 30;
            this.roundControlinterface.Size = new System.Drawing.Size(1701, 318);
            this.roundControlinterface.TabIndex = 39;
            this.roundControlinterface.Load += new System.EventHandler(this.roundControlinterface_Load);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Location = new System.Drawing.Point(56, 493);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1484, 546);
            this.panel2.TabIndex = 31;
            // 
            // ControlPanelUserList10
            // 
            this.ControlPanelUserList10.BackColor = System.Drawing.Color.Gainsboro;
            this.ControlPanelUserList10.Location = new System.Drawing.Point(36, 464);
            this.ControlPanelUserList10.Name = "ControlPanelUserList10";
            this.ControlPanelUserList10.Size = new System.Drawing.Size(1740, 575);
            this.ControlPanelUserList10.TabIndex = 37;
            this.ControlPanelUserList10.Paint += new System.Windows.Forms.PaintEventHandler(this.ControlPanelUserList10_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(806, 485);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 31);
            this.label1.TabIndex = 39;
            this.label1.Text = "User Role List ";
            // 
            // roundControl2
            // 
            this.roundControl2.BackColor = System.Drawing.Color.Teal;
            this.roundControl2.BackgroundColor = System.Drawing.Color.Teal;
            this.roundControl2.BorderColor = System.Drawing.Color.Red;
            this.roundControl2.BorderWidth = 2F;
            this.roundControl2.Location = new System.Drawing.Point(1480, 12);
            this.roundControl2.Margin = new System.Windows.Forms.Padding(2);
            this.roundControl2.Name = "roundControl2";
            this.roundControl2.Radius = 30;
            this.roundControl2.Size = new System.Drawing.Size(277, 63);
            this.roundControl2.TabIndex = 64;
            // 
            // roundControl1
            // 
            this.roundControl1.BackColor = System.Drawing.Color.Gainsboro;
            this.roundControl1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.roundControl1.BorderColor = System.Drawing.Color.Teal;
            this.roundControl1.BorderWidth = 2F;
            this.roundControl1.Location = new System.Drawing.Point(56, 466);
            this.roundControl1.Margin = new System.Windows.Forms.Padding(2);
            this.roundControl1.Name = "roundControl1";
            this.roundControl1.Radius = 30;
            this.roundControl1.Size = new System.Drawing.Size(1701, 561);
            this.roundControl1.TabIndex = 38;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1280, 540);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(417, 416);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            // 
            // picUserList
            // 
            this.picUserList.BackColor = System.Drawing.Color.Teal;
            this.picUserList.Image = ((System.Drawing.Image)(resources.GetObject("picUserList.Image")));
            this.picUserList.Location = new System.Drawing.Point(87, 21);
            this.picUserList.Name = "picUserList";
            this.picUserList.Size = new System.Drawing.Size(53, 45);
            this.picUserList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUserList.TabIndex = 36;
            this.picUserList.TabStop = false;
            this.picUserList.Click += new System.EventHandler(this.picUserList_Click);
            // 
            // UserRoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1942, 1222);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSearchUserRole);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgUserRole);
            this.Controls.Add(this.roundControl1);
            this.Controls.Add(this.ControlpanelUserRoleInput);
            this.Controls.Add(this.ControlPanelUserList10);
            this.Controls.Add(this.picUserList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SearchUserRole);
            this.Controls.Add(this.roundControlUserRole);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.roundControl2);
            this.Controls.Add(this.roundControlHeaderUserRole);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserRoleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserRole";
            this.Load += new System.EventHandler(this.UserRole_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgUserRole)).EndInit();
            this.ControlpanelUserRoleInput.ResumeLayout(false);
            this.ControlpanelUserRoleInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void txtUserId_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void txtRoleId_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.TextBox txtSearchUserRole;
        private System.Windows.Forms.Label SearchUserRole;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgUserRole;
        private RoundTextBoxProject.RoundControl roundControlHeaderUserRole;
        private RoundTextBoxProject.RoundControl roundControlUserRole;
        private System.Windows.Forms.Label RoleId;
        private System.Windows.Forms.Label UserId;
        private System.Windows.Forms.Panel ControlpanelUserRoleInput;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUpdateuser;
        private System.Windows.Forms.Button btnDeleteuser;
        private System.Windows.Forms.Button btnSaveAllUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picUserList;
        private System.Windows.Forms.ComboBox cboRole;
        private System.Windows.Forms.ComboBox cboUser;
        private System.Windows.Forms.Panel ControlPanelUserList10;
        private RoundTextBoxProject.RoundControl roundControlinterface;
        private System.Windows.Forms.Label label1;
        private RoundTextBoxProject.RoundControl roundControl2;
        private RoundTextBoxProject.RoundControl roundControl3;
        private RoundTextBoxProject.RoundControl roundControl7;
        private RoundTextBoxProject.RoundControl roundControl8;
        private RoundTextBoxProject.RoundControl roundControl9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RoundTextBoxProject.RoundControl roundControl1;
    }
}