using FCM.Data.Entities.Abstract_Classes;

namespace FCM.Data.Entities
{
    public class CoachingStaff : BasePersonEntity
    {
        public string Role { get; set; }

        public int ClubId { get; set; }
        public Club Club { get; set; }
    }
}
