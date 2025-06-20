namespace MySecondProject.OopPrinciples.Coupling;

public class EmailSender : INotificationService
{
    // public void SendEmail(string message)
    // {
    //     Console.WriteLine($"Sending email: {message}");
    // }

    public void SendNotification(string message)
    {
        Console.WriteLine($"Sending email: {message}");
    }
}