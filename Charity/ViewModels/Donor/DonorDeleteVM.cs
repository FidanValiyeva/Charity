using System.ComponentModel.DataAnnotations;

namespace Charity.ViewModels.Donor
{
    public class DonorDeleteVM
    {
        [Required]
        public int Id { get; set; }
    }
}
