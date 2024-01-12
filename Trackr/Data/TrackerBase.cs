using System.ComponentModel.DataAnnotations;

namespace Trackr.Data
{
    public class TrackerBase
    {
        [Required]
        public DateTime CreatedDate { get; set; }

        [Required]
        public DateTime UpdatedDate { get; set; }

        [Required]
        public string UserId { get; set; }
    }
}
