namespace Presentation.Model.Orders
{
    public enum PaymentStatus
    {
        None,
        Sent,
        Received,
        Clearing,
        Returned,
        Bounced,
        Completed
    }
}
