namespace MySecondProject.OopPrinciples.Coupling;

public class Order
{
    private readonly INotificationService _notificationService;

    public Order(INotificationService notificationService)
    {
        this._notificationService = notificationService;
    }
    public void PlaceOrder()
    {
        // place order logic
        // EmailSender emailSender = new EmailSender();
        // emailSender.SendEmail("Order placed successfully");
        // emailSender.SendNotification("Order placed successfully");
        this._notificationService.SendNotification("Order placed successfully");
    }
}