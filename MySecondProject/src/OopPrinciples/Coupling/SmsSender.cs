namespace MySecondProject.OopPrinciples.Coupling;

public class SmsSender : INotificationService
{
    public void SendNotification(string message)
    {
        Console.WriteLine($"SmsSender Notification: {message}");
    }
}