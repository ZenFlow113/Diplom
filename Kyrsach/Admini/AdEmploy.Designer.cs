namespace Kyrsach
{
    partial class AdEmploy
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thirdNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tasksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.delBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.changeBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAddU = new MaterialSkin.Controls.MaterialRaisedButton();
            this.backBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.descCheckBox = new System.Windows.Forms.CheckBox();
            this.sortComboBox = new System.Windows.Forms.ComboBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.positionIDDataGridViewTextBoxColumn,
            this.secondNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.thirdNameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.photoDataGridViewImageColumn,
            this.addressDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.positionsDataGridViewTextBoxColumn,
            this.tasksDataGridViewTextBoxColumn,
            this.usersDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 171);
            this.dataGridView1.TabIndex = 0;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            // 
            // positionIDDataGridViewTextBoxColumn
            // 
            this.positionIDDataGridViewTextBoxColumn.DataPropertyName = "PositionID";
            this.positionIDDataGridViewTextBoxColumn.HeaderText = "PositionID";
            this.positionIDDataGridViewTextBoxColumn.Name = "positionIDDataGridViewTextBoxColumn";
            // 
            // secondNameDataGridViewTextBoxColumn
            // 
            this.secondNameDataGridViewTextBoxColumn.DataPropertyName = "SecondName";
            this.secondNameDataGridViewTextBoxColumn.HeaderText = "SecondName";
            this.secondNameDataGridViewTextBoxColumn.Name = "secondNameDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // thirdNameDataGridViewTextBoxColumn
            // 
            this.thirdNameDataGridViewTextBoxColumn.DataPropertyName = "ThirdName";
            this.thirdNameDataGridViewTextBoxColumn.HeaderText = "ThirdName";
            this.thirdNameDataGridViewTextBoxColumn.Name = "thirdNameDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // photoDataGridViewImageColumn
            // 
            this.photoDataGridViewImageColumn.DataPropertyName = "Photo";
            this.photoDataGridViewImageColumn.HeaderText = "Photo";
            this.photoDataGridViewImageColumn.Name = "photoDataGridViewImageColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "E_mail";
            this.emailDataGridViewTextBoxColumn.HeaderText = "E_mail";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // positionsDataGridViewTextBoxColumn
            // 
            this.positionsDataGridViewTextBoxColumn.DataPropertyName = "Positions";
            this.positionsDataGridViewTextBoxColumn.HeaderText = "Positions";
            this.positionsDataGridViewTextBoxColumn.Name = "positionsDataGridViewTextBoxColumn";
            // 
            // tasksDataGridViewTextBoxColumn
            // 
            this.tasksDataGridViewTextBoxColumn.DataPropertyName = "Tasks";
            this.tasksDataGridViewTextBoxColumn.HeaderText = "Tasks";
            this.tasksDataGridViewTextBoxColumn.Name = "tasksDataGridViewTextBoxColumn";
            // 
            // usersDataGridViewTextBoxColumn
            // 
            this.usersDataGridViewTextBoxColumn.DataPropertyName = "Users";
            this.usersDataGridViewTextBoxColumn.HeaderText = "Users";
            this.usersDataGridViewTextBoxColumn.Name = "usersDataGridViewTextBoxColumn";
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataSource = typeof(Kyrsach.Employees);
            // 
            // delBtn
            // 
            this.delBtn.Depth = 0;
            this.delBtn.Location = new System.Drawing.Point(450, 381);
            this.delBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.delBtn.Name = "delBtn";
            this.delBtn.Primary = true;
            this.delBtn.Size = new System.Drawing.Size(125, 37);
            this.delBtn.TabIndex = 12;
            this.delBtn.Text = "Удалить";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Visible = false;
            // 
            // changeBtn
            // 
            this.changeBtn.Depth = 0;
            this.changeBtn.Location = new System.Drawing.Point(229, 381);
            this.changeBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Primary = true;
            this.changeBtn.Size = new System.Drawing.Size(125, 37);
            this.changeBtn.TabIndex = 11;
            this.changeBtn.Text = "Изменить";
            this.changeBtn.UseVisualStyleBackColor = true;
            this.changeBtn.Visible = false;
            // 
            // btnAddU
            // 
            this.btnAddU.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddU.Depth = 0;
            this.btnAddU.Location = new System.Drawing.Point(12, 381);
            this.btnAddU.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddU.Name = "btnAddU";
            this.btnAddU.Primary = true;
            this.btnAddU.Size = new System.Drawing.Size(125, 37);
            this.btnAddU.TabIndex = 10;
            this.btnAddU.Text = "Добавить";
            this.btnAddU.UseVisualStyleBackColor = false;
            this.btnAddU.Visible = false;
            // 
            // backBtn
            // 
            this.backBtn.Depth = 0;
            this.backBtn.Location = new System.Drawing.Point(663, 381);
            this.backBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.backBtn.Name = "backBtn";
            this.backBtn.Primary = true;
            this.backBtn.Size = new System.Drawing.Size(125, 37);
            this.backBtn.TabIndex = 9;
            this.backBtn.Text = "Назад";
            this.backBtn.UseVisualStyleBackColor = true;
            // 
            // filterComboBox
            // 
            this.filterComboBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Location = new System.Drawing.Point(615, 126);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(174, 30);
            this.filterComboBox.TabIndex = 16;
            // 
            // descCheckBox
            // 
            this.descCheckBox.AutoSize = true;
            this.descCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.descCheckBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descCheckBox.Location = new System.Drawing.Point(474, 128);
            this.descCheckBox.Name = "descCheckBox";
            this.descCheckBox.Size = new System.Drawing.Size(135, 25);
            this.descCheckBox.TabIndex = 15;
            this.descCheckBox.Text = "По убыванию";
            this.descCheckBox.UseVisualStyleBackColor = false;
            // 
            // sortComboBox
            // 
            this.sortComboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortComboBox.FormattingEnabled = true;
            this.sortComboBox.Items.AddRange(new object[] {
            "Без сортировки ",
            "Роль"});
            this.sortComboBox.Location = new System.Drawing.Point(284, 124);
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.Size = new System.Drawing.Size(184, 29);
            this.sortComboBox.TabIndex = 14;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(13, 126);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(250, 27);
            this.searchTextBox.TabIndex = 13;
            this.searchTextBox.Text = "Введите для поиска";
            // 
            // AdEmploy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.filterComboBox);
            this.Controls.Add(this.descCheckBox);
            this.Controls.Add(this.sortComboBox);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.changeBtn);
            this.Controls.Add(this.btnAddU);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdEmploy";
            this.Text = "Данные сотрудника";
            this.Load += new System.EventHandler(this.AdEmploy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thirdNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn photoDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tasksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usersDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private MaterialSkin.Controls.MaterialRaisedButton delBtn;
        private MaterialSkin.Controls.MaterialRaisedButton changeBtn;
        private MaterialSkin.Controls.MaterialRaisedButton btnAddU;
        private MaterialSkin.Controls.MaterialRaisedButton backBtn;
        public System.Windows.Forms.ComboBox filterComboBox;
        private System.Windows.Forms.CheckBox descCheckBox;
        private System.Windows.Forms.ComboBox sortComboBox;
        private System.Windows.Forms.TextBox searchTextBox;
    }
}