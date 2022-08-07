using Weather.DAL.Interfaces;

namespace Weather.DAL.Models
{
    public abstract class Entity : IEntity
    {
        public int Id { get; set; }
    }
}
