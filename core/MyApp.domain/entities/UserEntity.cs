namespace cleanarchteture.domain.entities
{
    public sealed class User : BaseEntity
    {
        public string Name { get; set; }
       public string Email { get; set; }
    }
}