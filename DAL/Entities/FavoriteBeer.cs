using DAL.Entities.BaseEntity;

namespace DAL.Entities
{
    public class FavoriteBeer : Entity
    {
        public string UserId { get; set; }
        public string BeerId { get; set; }
    }
}
