namespace MySecondProject.SOLID.S;

public class User
{
    public  string UserName { get; set; }
    
    public string Email { get; set; }

    // public void Register()
    // {
    //     //Register user logic here
    //     
    //     //Send email
    //     EmailSender emailSender = new EmailSender();
    //     emailSender.SendEmail(Email, "Welcome to our plaform");
    // }
}