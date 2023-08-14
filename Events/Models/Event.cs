using System.ComponentModel.DataAnnotations;
using Events.Models;

namespace Events.Models
{
    public class Event
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }
        [Required]
        public DateTime Start { get; set; }
        [Required]
        public DateTime End { get; set; }
        [Required]
        [MaxLength(50)]
        public string Location { get; set; }
        [Required]
        public bool IsPublic { get; set; }
        [Required]
        public int TotalTicket { get; set; }
        [Required]
        public decimal Price { get; set; }
        public virtual ApplicationUser? Author { get; set; }
    } 
}

