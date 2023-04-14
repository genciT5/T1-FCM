using FCM.Data.Entities;
using FCM.Data.Helpers;
using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using FCM.Models.Players;
using System.Collections.Generic;

namespace FCM.Players
{
    public partial class PlayersForm : Form
    {
        public PlayersForm()
        {
            InitializeComponent();

            cbxClubs.DisplayMember = "ClubName";
            cbxClubs.ValueMember = "Id";
        }

        private void PlayersForm_Load(object sender, EventArgs e)
        {
            var clubs = DatabaseHelper.ExecuteStoredProcedure("GetClubs", null).ToClubsList();
            clubs.Insert(0, new Club { Id = 0, ClubName = "Select a club" });
            cbxClubs.DataSource = clubs;

            //var players = DatabaseHelper.ExecuteStoredProcedure("GetPlayers")
            DisplayPlayersOfSelectedClub();
        }

        private void cbxClubs_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayPlayersOfSelectedClub();
        }

        private void btnRegisterPlayer_Click(object sender, EventArgs e)
        {
            using (var registerPlayerForm = new RegisterPlayerForm())
            {
                registerPlayerForm.ShowDialog();
            }

            PlayersForm_Load(null, null);
        }

        private void DisplayPlayersOfSelectedClub()
        {
            var selectedClub = (Club)cbxClubs.SelectedItem;

            if (selectedClub != null)
            {
                List<Player> players;

                if (selectedClub.Id != 0)
                {
                    var parameters = new[]
                    {
                        new SqlParameter("@ClubId", SqlDbType.Int) { Value = selectedClub.Id }
                    };

                     players = DatabaseHelper.ExecuteStoredProcedure(StoredProcedures.GetPlayers, parameters).ToPlayersList();
                }
                else
                {
                    players = DatabaseHelper.ExecuteStoredProcedure(StoredProcedures.GetAllPlayers, null).ToPlayersList();
                }


                var plyersGridModelList = new List<PlayersGridViewModel>();
                foreach (var player in players)
                {
                    plyersGridModelList.Add(new PlayersGridViewModel
                    {
                        FirstName = player.FirstName,
                        LastName = player.LastName,
                        ClubId = player.ClubId,
                        EmailAddress = player.EmailAddress,
                        Id = player.Id,
                        PersonalIdNumber = player.PersonalIdNumber,
                        PhoneNumber = player.PhoneNumber,
                        PlayingPosition = player.PlayingPosition,
                        //ClubName = player.Club.ClubName
                    });
                }

                playersGridViewModelBindingSource.DataSource = plyersGridModelList;
            }
        }
    }
}
