namespace EcommerceLambda.Domain.Entities.Request
{
    public enum RequestStatus
    {
        AWAITING_PAYMENT,
        AWAITING_SHIPPING,
        SHIPPED,
        DELIVERED,
        CANCELED
    }
}
