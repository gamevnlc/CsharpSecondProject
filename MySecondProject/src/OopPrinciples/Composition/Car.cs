namespace MySecondProject.OopPrinciples.Composition;

public class Car
{
    private Engine _engine = new Engine();
    
    private Chassis _chassis = new Chassis();
    
    private Seats _seats = new Seats();
    
    private Wheels _wheels = new Wheels();

    public void StartCar()
    {
        _engine.Start();
        _wheels.Rotate();
        _chassis.Support();
        _seats.Sit();
        Console.WriteLine("Car started");
    }
}