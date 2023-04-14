namespace FCM.Data.Entities.Abstract_Classes
{
    public abstract class BasePersonEntity : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string PersonalIdNumber { get; set; }
    }
}
