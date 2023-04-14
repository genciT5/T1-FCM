using FCM.Data.Entities.Abstract_Classes;

namespace FCM.Data.Entities
{
    public class Player : BasePersonEntity
    {
        public string PlayingPosition { get; set; }
        public int ClubId { get; set; }
        public Club Club { get; set; }
    }
}
