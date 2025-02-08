using System.ComponentModel.DataAnnotations;

namespace Charity.ViewModels.Donation
{
    public class DonationDeleteVM
    {
        [Required]
        public int Id { get; set; }

    }
}
