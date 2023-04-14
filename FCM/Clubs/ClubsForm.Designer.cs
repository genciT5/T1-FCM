namespace FCM.Clubs
{
    partial class Clubs
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
            this.dataGridViewClubs = new System.Windows.Forms.DataGridView();
            this.colClubId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clubsGridViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxClubs = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dateTimePickerFoundingDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegisterClub = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClubs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubsGridViewModelBindingSource)).BeginInit();
            this.groupBoxClubs.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewClubs
            // 
            this.dataGridViewClubs.AutoGenerateColumns = false;
            this.dataGridViewClubs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClubs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colClubId,
            this.colName});
            this.dataGridViewClubs.DataSource = this.clubsGridViewModelBindingSource;
            this.dataGridViewClubs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewClubs.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewClubs.Name = "dataGridViewClubs";
            this.dataGridViewClubs.Size = new System.Drawing.Size(292, 205);
            this.dataGridViewClubs.TabIndex = 0;
            // 
            // colClubId
            // 
            this.colClubId.DataPropertyName = "ClubId";
            this.colClubId.HeaderText = "Club Id";
            this.colClubId.Name = "colClubId";
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.Width = 150;
            // 
            // groupBoxClubs
            // 
            this.groupBoxClubs.Controls.Add(this.dataGridViewClubs);
            this.groupBoxClubs.Location = new System.Drawing.Point(4, 214);
            this.groupBoxClubs.Name = "groupBoxClubs";
            this.groupBoxClubs.Size = new System.Drawing.Size(298, 224);
            this.groupBoxClubs.TabIndex = 1;
            this.groupBoxClubs.TabStop = false;
            this.groupBoxClubs.Text = "Clubs";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(102, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 2;
            // 
            // dateTimePickerFoundingDate
            // 
            this.dateTimePickerFoundingDate.Location = new System.Drawing.Point(102, 65);
            this.dateTimePickerFoundingDate.Name = "dateTimePickerFoundingDate";
            this.dateTimePickerFoundingDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFoundingDate.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Club Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Founding Date:";
            // 
            // btnRegisterClub
            // 
            this.btnRegisterClub.Location = new System.Drawing.Point(196, 103);
            this.btnRegisterClub.Name = "btnRegisterClub";
            this.btnRegisterClub.Size = new System.Drawing.Size(106, 23);
            this.btnRegisterClub.TabIndex = 6;
            this.btnRegisterClub.Text = "Register Club";
            this.btnRegisterClub.UseVisualStyleBackColor = true;
            this.btnRegisterClub.Click += new System.EventHandler(this.btnRegisterClub_Click);
            // 
            // Clubs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 450);
            this.Controls.Add(this.btnRegisterClub);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerFoundingDate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.groupBoxClubs);
            this.Name = "Clubs";
            this.Text = "ClubsForm";
            this.Load += new System.EventHandler(this.ClubsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClubs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubsGridViewModelBindingSource)).EndInit();
            this.groupBoxClubs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewClubs;
        private System.Windows.Forms.GroupBox groupBoxClubs;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dateTimePickerFoundingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn foundingDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource clubsGridViewModelBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegisterClub;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClubId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
    }
}