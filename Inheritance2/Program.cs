// Create a base class called Vehicle that has two properties,
// Make and Model, and a method called Start().
// Create a derived class called Car that inherits from Vehicle and
// adds a property called NumberOfDoors and overrides the Start() method
// to print out "Starting the car".
// Create another derived class called Motorcycle that inherits from Vehicle
// and adds a property called HasSideCar and overrides the Start() method
// to print out "Starting the motorcycle".

using Inheritance2;

//Vehicle vehicle = new Vehicle();

//Vehicle vehicle2 = new Vehicle();

//Vehicle vehicle3 = new Vehicle("Ford");

//Console.WriteLine("Vnesi proizvoditel: ");
//var make = Console.ReadLine();
//Console.WriteLine("Vnesi model: ");
//var model = Console.ReadLine();
//Console.WriteLine("Vnesi godina: ");
//var year = int.Parse(Console.ReadLine());

//Vehicle vehicle4 = new Vehicle(make, model, year);

//var vehicleData = vehicle4.ToString();
//Console.WriteLine(vehicleData);

Vehicle vehicle = new Vehicle();
Car car = new Car();
Motorcycle motorcycle = new Motorcycle();

vehicle.Start();
car.Start();
motorcycle.Start();

Console.ReadLine();