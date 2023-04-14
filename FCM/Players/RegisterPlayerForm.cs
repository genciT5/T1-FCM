using FCM.Data.Entities;
using FCM.Data.Helpers;
using FCM.Models.Players;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FCM.Players
{
    public partial class RegisterPlayerForm : Form
    {
        public RegisterPlayerForm()
        {
            InitializeComponent();

            cbxClubs.DisplayMember = "ClubName";
            cbxClubs.ValueMember = "Id";
        }

        private void btnRegisterPlayer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("First Name field can not be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Last Name field can not be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPersonalNumber.Text))
            {
                MessageBox.Show("First Name can not be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbxClubs.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a club first from the clubs drop-down menu", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedClub = (Club)cbxClubs.SelectedItem;

            if (selectedClub != null)
            {
                var parameters = new[]
                {
                    new SqlParameter("@FirstName", SqlDbType.VarChar) { Value = txtFirstName.Text },
                    new SqlParameter("@LastName", SqlDbType.VarChar) { Value = txtLastName.Text },
                    new SqlParameter("@PlayingPosition", SqlDbType.VarChar) { Value = txtPlayingPosition.Text },
                    new SqlParameter("@PhoneNumber", SqlDbType.VarChar) { Value = txtPhoneNumber.Text },
                    new SqlParameter("@EmailAddress", SqlDbType.VarChar) { Value = txtEmail.Text },
                    new SqlParameter("@PersonalIdNumber", SqlDbType.VarChar) { Value = txtPhoneNumber.Text },
                    new SqlParameter("@ClubId", SqlDbType.Int) { Value = selectedClub.Id}
                };

                var result = DatabaseHelper.ExecuteStoredProcedure("CreatePlayer", parameters);

                MessageBox.Show("Player Registered", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                var dialogResult = MessageBox.Show("Could not register player, Do you want to try again?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.No)
                {
                    this.Close();
                }
            }
        }

        private void RegisterPlayerForm_Load(object sender, EventArgs e)
        {
            var clubs = DatabaseHelper.ExecuteStoredProcedure("GetClubs", null).ToClubsList();
            clubs.Insert(0, new Club { Id = 0, ClubName = "Select a club" });
            cbxClubs.DataSource = clubs;
        }
    }
}

