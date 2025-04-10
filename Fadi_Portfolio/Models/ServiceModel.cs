using System.ComponentModel.DataAnnotations;

namespace Fadi_Portfolio.Models
{
    public class ServiceModel
    {
        public int? Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
