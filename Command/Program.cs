//using CommandPattern.Exe2;
//using CommandPattern.Site;
using CommandPattern.Calculator;
using System;

Console.WriteLine("Hello World!");
//Exe2
//var receiver = new Receiver();
//var commandSatate = (State)receiver.Action(new Command(1, "Zé da Silva"));

//Site
//Invoker invoker = new Invoker();
//invoker.SetOnStart(new SimpleCommand("Say Hi!"));
//Receiver receiver = new Receiver();
//invoker.SetOnFinish(new ComplexCommand(receiver, "Send email", "Save report"));
//invoker.DoSomethingImportant();


//Calculator
Calculator calculator = new Calculator();
Invoker invoker = new Invoker();

invoker.ExecuteCommand(new CalculatorCommand(calculator, '+', 100));
invoker.ExecuteCommand(new CalculatorCommand(calculator, '-', 50));
invoker.ExecuteCommand(new CalculatorCommand(calculator, '*', 10));
invoker.ExecuteCommand(new CalculatorCommand(calculator, '/', 2));

Console.WriteLine("\nUndoing...\n");
invoker.Undo();
invoker.Undo();
invoker.Undo();
invoker.Undo();
invoker.Undo();

Console.ReadLine();