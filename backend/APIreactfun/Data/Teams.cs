using System.ComponentModel.DataAnnotations;

namespace APIreactfun.Data
{
    public class Teams
    {
        [Key]
        public int TeamId { get; set; }

        public string? TeamName { get; set; }

        public int? CaptainId { get; set; }
    }
}
