using System.ComponentModel.DataAnnotations;

namespace Fadi_Portfolio.Models
{
    public class CertificateModel
    {
        public int? Id { get; set; }
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }
        [MaxLength(50)]
        [Required]
        public string From { get; set; }
        [Required]
        public DateOnly Date { get; set; }
        [MaxLength(30)]
        [Required]
        public string Level { get; set; }
    }
}
