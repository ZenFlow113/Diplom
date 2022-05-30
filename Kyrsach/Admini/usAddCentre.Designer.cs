namespace Kyrsach.Admini
{
    partial class usAddCentre
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
            this.btnBackPos = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textBoxUserID = new System.Windows.Forms.TextBox();
            this.labelUserId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEmplId = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.textBoxPaswrd = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.textBoxRole = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBackPos
            // 
            this.btnBackPos.Depth = 0;
            this.btnBackPos.Location = new System.Drawing.Point(294, 366);
            this.btnBackPos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBackPos.Name = "btnBackPos";
            this.btnBackPos.Primary = true;
            this.btnBackPos.Size = new System.Drawing.Size(128, 44);
            this.btnBackPos.TabIndex = 7;
            this.btnBackPos.Text = "Назад";
            this.btnBackPos.UseVisualStyleBackColor = true;
            this.btnBackPos.Click += new System.EventHandler(this.btnBackPos_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Depth = 0;
            this.btnAdd.Location = new System.Drawing.Point(52, 366);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Primary = true;
            this.btnAdd.Size = new System.Drawing.Size(128, 44);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // textBoxUserID
            // 
            this.textBoxUserID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserID.Location = new System.Drawing.Point(52, 98);
            this.textBoxUserID.Multiline = true;
            this.textBoxUserID.Name = "textBoxUserID";
            this.textBoxUserID.Size = new System.Drawing.Size(146, 39);
            this.textBoxUserID.TabIndex = 8;
            // 
            // labelUserId
            // 
            this.labelUserId.AutoSize = true;
            this.labelUserId.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserId.Location = new System.Drawing.Point(54, 73);
            this.labelUserId.Name = "labelUserId";
            this.labelUserId.Size = new System.Drawing.Size(66, 22);
            this.labelUserId.TabIndex = 9;
            this.labelUserId.Text = "UserID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "EmployeeID";
            // 
            // textBoxEmplId
            // 
            this.textBoxEmplId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmplId.Location = new System.Drawing.Point(52, 180);
            this.textBoxEmplId.Multiline = true;
            this.textBoxEmplId.Name = "textBoxEmplId";
            this.textBoxEmplId.Size = new System.Drawing.Size(146, 39);
            this.textBoxEmplId.TabIndex = 10;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(278, 73);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(65, 22);
            this.lblLogin.TabIndex = 13;
            this.lblLogin.Text = "Логин";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLogin.Location = new System.Drawing.Point(276, 98);
            this.textBoxLogin.Multiline = true;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(146, 39);
            this.textBoxLogin.TabIndex = 12;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(278, 155);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(80, 22);
            this.lblPassword.TabIndex = 15;
            this.lblPassword.Text = "Пароль";
            // 
            // textBoxPaswrd
            // 
            this.textBoxPaswrd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPaswrd.Location = new System.Drawing.Point(276, 180);
            this.textBoxPaswrd.Multiline = true;
            this.textBoxPaswrd.Name = "textBoxPaswrd";
            this.textBoxPaswrd.Size = new System.Drawing.Size(146, 39);
            this.textBoxPaswrd.TabIndex = 14;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(272, 248);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(52, 22);
            this.lblRole.TabIndex = 17;
            this.lblRole.Text = "Роль";
            // 
            // textBoxRole
            // 
            this.textBoxRole.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRole.Location = new System.Drawing.Point(276, 273);
            this.textBoxRole.Multiline = true;
            this.textBoxRole.Name = "textBoxRole";
            this.textBoxRole.Size = new System.Drawing.Size(146, 39);
            this.textBoxRole.TabIndex = 16;
            // 
            // usAddCentre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(477, 450);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.textBoxRole);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.textBoxPaswrd);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxEmplId);
            this.Controls.Add(this.labelUserId);
            this.Controls.Add(this.textBoxUserID);
            this.Controls.Add(this.btnBackPos);
            this.Controls.Add(this.btnAdd);
            this.Name = "usAddCentre";
            this.Text = "usAddCentre";
            this.Load += new System.EventHandler(this.usAddCentre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnBackPos;
        private MaterialSkin.Controls.MaterialRaisedButton btnAdd;
        private System.Windows.Forms.TextBox textBoxUserID;
        private System.Windows.Forms.Label labelUserId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEmplId;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox textBoxPaswrd;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox textBoxRole;
    }
}