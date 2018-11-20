using System;
using System.ComponentModel.DataAnnotations;

namespace Listener.Models
{
    public class WorkOut
    {
        public int Id { get; set; }
        [Required]
        public DateTimeOffset Date { get; set; }
        public int distanceInMenters { get; set; }
        [Required]
        public int TimeInSeconds { get; set; }
    }
}