using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities.BaseEntity
{
    public class Entity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
    }
}
