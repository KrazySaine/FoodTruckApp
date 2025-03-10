﻿using System.ComponentModel.DataAnnotations;
using Repository.Models.Client;

namespace Repository.Models.Menu
{
    public class Special
    {
        [Key]
        public int Special_ID { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public decimal Discount { get; set; } = decimal.MinValue;
        [Required]
        public DateOnly StartDate { get; set; }
        [Required]
        public DateOnly EndDate { get; set; }

    }
}
