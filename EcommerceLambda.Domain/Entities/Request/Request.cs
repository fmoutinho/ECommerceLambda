

namespace EcommerceLambda.Domain.Entities.Request
{
    public class Request
    {
        public Guid Id { get; set; }
        public RequestStatus Status { get; set; }
        public string ClientDocument => Client.Document;
        public Client.Client Client { get; set; }
        public decimal TotalValue => RequestItems.Sum(x => x.UnitValue * x.Quantity);
        public List<RequestItem> RequestItems { get; set; } = new List<RequestItem>();
    }
}
