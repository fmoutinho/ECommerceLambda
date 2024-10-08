namespace EcommerceLambda.Domain.Entities.Client
{
    public class Client
    {
        public string? Document { get; set; }

        public string? Name { get; set; }

        public string? Email { get; set; }

        public Address? Address { get; set; }
    }
}
