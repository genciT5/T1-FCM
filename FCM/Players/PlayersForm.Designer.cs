namespace FCM.Players
{
    partial class PlayersForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxClubs = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegisterPlayer = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalIdNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playingPositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clubIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playersGridViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClubName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playersGridViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.emailAddressDataGridViewTextBoxColumn,
            this.personalIdNumberDataGridViewTextBoxColumn,
            this.playingPositionDataGridViewTextBoxColumn,
            this.clubIdDataGridViewTextBoxColumn,
            this.ClubName});
            this.dataGridView1.DataSource = this.playersGridViewModelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(660, 374);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(672, 399);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Players";
            // 
            // cbxClubs
            // 
            this.cbxClubs.FormattingEnabled = true;
            this.cbxClubs.Location = new System.Drawing.Point(563, 23);
            this.cbxClubs.Name = "cbxClubs";
            this.cbxClubs.Size = new System.Drawing.Size(121, 21);
            this.cbxClubs.TabIndex = 2;
            this.cbxClubs.SelectedIndexChanged += new System.EventHandler(this.cbxClubs_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(522, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Club:";
            // 
            // btnRegisterPlayer
            // 
            this.btnRegisterPlayer.Location = new System.Drawing.Point(18, 23);
            this.btnRegisterPlayer.Name = "btnRegisterPlayer";
            this.btnRegisterPlayer.Size = new System.Drawing.Size(135, 23);
            this.btnRegisterPlayer.TabIndex = 4;
            this.btnRegisterPlayer.Text = "Register New Player";
            this.btnRegisterPlayer.UseVisualStyleBackColor = true;
            this.btnRegisterPlayer.Click += new System.EventHandler(this.btnRegisterPlayer_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 30;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // emailAddressDataGridViewTextBoxColumn
            // 
            this.emailAddressDataGridViewTextBoxColumn.DataPropertyName = "EmailAddress";
            this.emailAddressDataGridViewTextBoxColumn.HeaderText = "EmailAddress";
            this.emailAddressDataGridViewTextBoxColumn.Name = "emailAddressDataGridViewTextBoxColumn";
            // 
            // personalIdNumberDataGridViewTextBoxColumn
            // 
            this.personalIdNumberDataGridViewTextBoxColumn.DataPropertyName = "PersonalIdNumber";
            this.personalIdNumberDataGridViewTextBoxColumn.HeaderText = "PersonalIdNumber";
            this.personalIdNumberDataGridViewTextBoxColumn.Name = "personalIdNumberDataGridViewTextBoxColumn";
            // 
            // playingPositionDataGridViewTextBoxColumn
            // 
            this.playingPositionDataGridViewTextBoxColumn.DataPropertyName = "PlayingPosition";
            this.playingPositionDataGridViewTextBoxColumn.HeaderText = "PlayingPosition";
            this.playingPositionDataGridViewTextBoxColumn.Name = "playingPositionDataGridViewTextBoxColumn";
            // 
            // clubIdDataGridViewTextBoxColumn
            // 
            this.clubIdDataGridViewTextBoxColumn.DataPropertyName = "ClubId";
            this.clubIdDataGridViewTextBoxColumn.HeaderText = "ClubId";
            this.clubIdDataGridViewTextBoxColumn.Name = "clubIdDataGridViewTextBoxColumn";
            // 
            // playersGridViewModelBindingSource
            // 
            this.playersGridViewModelBindingSource.DataSource = typeof(FCM.Models.Players.PlayersGridViewModel);
            // 
            // ClubName
            // 
            this.ClubName.DataPropertyName = "ClubName";
            this.ClubName.HeaderText = "Club Name";
            this.ClubName.Name = "ClubName";
            // 
            // PlayersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 488);
            this.Controls.Add(this.btnRegisterPlayer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxClubs);
            this.Controls.Add(this.groupBox1);
            this.Name = "PlayersForm";
            this.Text = "PlayersForm";
            this.Load += new System.EventHandler(this.PlayersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playersGridViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxClubs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personalIdNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playingPositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clubIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource playersGridViewModelBindingSource;
        private System.Windows.Forms.Button btnRegisterPlayer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClubName;
    }
}