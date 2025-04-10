using System.ComponentModel.DataAnnotations.Schema;

namespace Fadi_Portfolio.Entities
{
    public class ProImage : BaseEntity
    {
        public int ProjectId { get; set; }
        public string Image { get; set; }

        [ForeignKey(nameof(ProjectId))]
        public Project Project { get; set; }
    }
}
