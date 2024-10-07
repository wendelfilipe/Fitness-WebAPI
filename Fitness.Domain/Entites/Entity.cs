namespace Fitness.Domain.Entites
{
    public abstract class Entity
    {
        public int Id { get; protected set; }
        public DateTime Created_at { get; protected set; }
        public DateTime Deleted_at{ get; protected set; }
        public DateTime Updated_at { get; protected set; }
    }
}