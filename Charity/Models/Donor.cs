namespace Charity.Models
{
    public class Donor:BaseEntity
    {
        public string FirstName {  get; set; }  
        public string LastName { get; set; }
        public string Email {  get; set; }
        public string Address {  get; set; }
        public string Message {  get; set; }           
        public decimal TotalDonationAmmount {  get; set; }
        public int UserId { get; set; }
        public User User { get; set; }


    }
}
