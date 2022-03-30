using System;
using System.ComponentModel.DataAnnotations;

namespace SportsStore.Models
{
    public class News
    {
        public long NewsId { get; set; }

        [Required(ErrorMessage = "Please enter a News Title")]
        public string NewsTitle { get; set; }

        [Required(ErrorMessage = "Please enter a News Text")]
        public string NewsText { get; set; }

        [Required(ErrorMessage = "Please enter a News Image Link")]
        public string ImageLink { get; set; }

    }
}