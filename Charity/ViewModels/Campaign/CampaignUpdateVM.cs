﻿using Charity.Enums;
using Charity.Models;
using System.ComponentModel.DataAnnotations;

namespace Charity.ViewModels.Campaign
{
    public class CampaignUpdateVM
    {
        [Required]
        public int Id { get; set; }

        [Required, MaxLength(100, ErrorMessage = "Kampaniya adı maksimum 100 simvol ola bilər.")]
        public string Name { get; set; }

        [Required, MaxLength(1000, ErrorMessage = "Açıqlama maksimum 1000 simvol ola bilər.")]
        public string Description { get; set; }

        [Required, Url(ErrorMessage = "Düzgün URL formatı daxil edin.")]
        public string ImageUrl { get; set; }

        [Required, Range(1, double.MaxValue, ErrorMessage = "Məqsəd məbləği müsbət bir rəqəm olmalıdır.")]
        public decimal TargetAmount { get; set; }

        [Required, DataType(DataType.Date)]
        public DateTime? EndDate { get; set; }
        [Required]
        public CampaignStatus Status { get; set; }
    }
}
