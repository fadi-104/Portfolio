using System.ComponentModel.DataAnnotations.Schema;

namespace Fadi_Portfolio.Entities
{
    public class ProTech : BaseEntity
    {
        public int ProjectId { get; set; }
        public string TechName { get; set; }

        [ForeignKey(nameof(ProjectId))]
        public Project Project { get; set; }

    }
}
