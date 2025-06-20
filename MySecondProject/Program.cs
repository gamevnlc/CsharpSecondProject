// See https://aka.ms/new-console-template for more information
//Encapsulation

using MySecondProject.OopPrinciples.Abstraction;
using MySecondProject.OopPrinciples.Encapsulation;

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
EmailService emailService = new EmailService();
// emailService.Connect();
// emailService.Authenticate();
emailService.SendEmail();
// emailService.Disconnect();
Console.ReadLine();