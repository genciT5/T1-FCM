using FCM.Data.Entities;
using FCM.Data.Helpers;
using FCM.Models.Clubs;
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

namespace FCM.Clubs
{
    public partial class Clubs : Form
    {
        public Clubs()
        {
            InitializeComponent();
        }

        private void btnRegisterClub_Click(object sender, EventArgs e)
        {
            var club = new Club
            {
                ClubName = txtName.Text,
                FoundingDate = dateTimePickerFoundingDate.Value
            };

            var result = DatabaseHelper.ExecuteStoredProcedure(StoredProcedures.CreateClub, new[]
            {
                new SqlParameter("@ClubName", SqlDbType.NVarChar) { Value = club.ClubName },
                new SqlParameter("@FoundingDate", SqlDbType.DateTime) { Value = club.FoundingDate }
            });

            clubsGridViewModelBindingSource.Add(new ClubsGridViewModel
            {
                ClubId = club.Id, 
                Name = club.ClubName,
                FoundingDate = club.FoundingDate
            });
        }

        private void ClubsForm_Load(object sender, EventArgs e)
        {
            var clubs = DatabaseHelper.ExecuteStoredProcedure(StoredProcedures.GetClubs, null);

            foreach (DataRow row in clubs.Rows)
            {
                var club = new ClubsGridViewModel
                {
                    ClubId = Convert.ToInt32(row["Id"]),
                    Name = Convert.ToString(row["ClubName"]),
                    FoundingDate = Convert.ToDateTime(row["FoundingDate"])
                };

                clubsGridViewModelBindingSource.Add(club);
            }
        }
    }
}
