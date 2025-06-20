// See https://aka.ms/new-console-template for more information
//Encapsulation
// BadBankAccount badAccount = new BadBankAccount();
// badAccount.balance = 100;
//
// Console.WriteLine(badAccount.balance);
// BankAccount bankAccount = new BankAccount(100);
//
// Console.WriteLine($"Balance: {bankAccount.GetBalance()}");
//
// bankAccount.Deposit(50);
//
// Console.WriteLine($"Balance: {bankAccount.GetBalance()}");
//
// bankAccount.Withdraw(-200);
//
// Console.WriteLine($"Balance: {bankAccount.GetBalance()}");

// Abstraction
// EmailService emailService = new EmailService();
// emailService.Connect();
// emailService.Authenticate();
// emailService.SendEmail();
// emailService.Disconnect();

//Inheritance

// Car car = new Car();
//
// car.Brand = "Ford";
// car.Start();
// car.Stop();
//
// // Unique
// car.NumberOfDoors = 4;
// car.NumberOfWheels = 4;
// Bike bike = new Bike();
// bike.NumberOfWheels = 2;
// bike.Start();
// bike.Stop();

//Polymorphism
// List<Vehicle> vehicles = new List<Vehicle>();
// vehicles.Add(new Car {});
// vehicles.Add(new Motorcycle{});
//
// foreach (var vehicle in vehicles)
// {
//     vehicle.Start();
// }

//Coupling
// Order order = new Order(new EmailSender());
// Order order = new Order(new SmsSender());
// order.PlaceOrder();
//Composition
// using MySecondProject.OopPrinciples.Composition;
//
// Car car = new Car();
// car.StartCar();
//L

using MySecondProject.SOLID.L;

// var rect = new Square();
// rect.Height = 10;
// rect.Width = 5;
//
// Console.WriteLine($"Expected area = 10 * 5 = 50");
// Console.WriteLine($"Actual area = {rect.Area}");

Shape rectangle = new Rectangle{Width = 4, Height = 5};

Console.WriteLine($"Area of rectangle {rectangle.Area}");

Shape square = new Square{SideLength = 5};

Console.WriteLine($"Area of square {square.Area}");

Console.ReadLine();