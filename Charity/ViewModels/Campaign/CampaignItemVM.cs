using Charity.Enums;
using Charity.Models;
using System.ComponentModel.DataAnnotations;

namespace Charity.ViewModels.Campaign
{
    public class CampaignItemVM
    {      
        public int Id { get; set; }        
        public string Name { get; set; } 
        public string Description { get; set; }        
        public string ImageUrl { get; set; }        
        public decimal TargetAmount { get; set; }     
        public decimal CollectedAmount { get; set; }      
        public DateTime? EndDate { get; set; }
        public CampaignStatus Status { get; set; }
    }
}
