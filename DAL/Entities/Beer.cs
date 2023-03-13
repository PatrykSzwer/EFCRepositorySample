using DAL.Entities.BaseEntity;

namespace DAL.Entities
{
    public class Beer : Entity
    {
        public string Name { get; set; }
        public double Alcohol { get; set; }
    }
}
