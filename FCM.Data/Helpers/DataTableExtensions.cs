using FCM.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace FCM.Data.Helpers
{
    public static class DataTableExtensions
    {
        public static List<Player> ToPlayersList(this DataTable table)
        {
            var players = new List<Player>();

            foreach (DataRow row in table.Rows)
            {
                var player = new Player
                {
                    Id = Convert.ToInt32(row["Id"]),
                    FirstName = Convert.ToString(row["FirstName"]),
                    LastName = Convert.ToString(row["LastName"]),
                    PhoneNumber = Convert.ToString(row["PhoneNumber"]),
                    EmailAddress = Convert.ToString(row["EmailAddress"]),
                    PersonalIdNumber = Convert.ToString(row["PersonalIdNumber"]),
                    PlayingPosition = Convert.ToString(row["PlayingPosition"]),
                    ClubId = Convert.ToInt32(row["ClubId"])
                };

                players.Add(player);
            }

            return players;
        }

        public static List<Club> ToClubsList(this DataTable table)
        {
            var clubs = new List<Club>();

            foreach (DataRow row in table.Rows)
            {
                var club = new Club
                {
                    Id = Convert.ToInt32(row["Id"]),
                    ClubName = Convert.ToString(row["ClubName"]),
                    FoundingDate = Convert.ToDateTime(row["FoundingDate"])
                };

                clubs.Add(club);
            }

            return clubs;
        }

        public static List<CoachingStaff> ToCoachingStaffList(this DataTable table)
        {
            var coachingStaff = new List<CoachingStaff>();

            foreach (DataRow row in table.Rows)
            {
                var staff = new CoachingStaff
                {
                    Id = Convert.ToInt32(row["Id"]),
                    FirstName = Convert.ToString(row["FirstName"]),
                    LastName = Convert.ToString(row["LastName"]),
                    PhoneNumber = Convert.ToString(row["PhoneNumber"]),
                    EmailAddress = Convert.ToString(row["EmailAddress"]),
                    PersonalIdNumber = Convert.ToString(row["PersonalIdNumber"]),
                    Role = Convert.ToString(row["Role"]),
                    ClubId = Convert.ToInt32(row["ClubId"])
                };

                coachingStaff.Add(staff);
            }

            return coachingStaff;
        }
    }
}
