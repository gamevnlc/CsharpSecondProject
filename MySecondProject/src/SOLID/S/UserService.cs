namespace MySecondProject.SOLID.S;

public class UserService
{
    public void Register(User user)
    {
        //Register user logic here
        
        //Send email
        EmailSender emailSender = new EmailSender();
        emailSender.SendEmail(user.Email, "Welcome to our platform");
    }
}