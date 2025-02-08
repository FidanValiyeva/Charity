using System.ComponentModel.DataAnnotations;

namespace Charity.ViewModels.Campaign
{
    public class CampaignDeleteVM
    {
        [Required]
        public int Id { get; set; }

        public string? Name { get; set; }
    }
}
