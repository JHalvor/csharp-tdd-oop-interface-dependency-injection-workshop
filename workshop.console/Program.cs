
//Interface - a contract


//1
using workshop.console.Examples.Calculator;
using workshop.console.Examples.Car;
using workshop.console.Examples.Car.Engines;
using workshop.console.Examples.ConsoleOrSpeak;
using workshop.console.Examples.Shop;
using workshop.console.Examples.Shop.Products;

AddCalcEngine addCalcEngine = new AddCalcEngine();
MultiplyCalcEngine multiplyCalcEngine = new MultiplyCalcEngine();

Calculator calculator = new Calculator(multiplyCalcEngine);
int a = 3;
int b = 2;

int result = calculator.Calculate(a, b);

//Console.WriteLine(result);



//2
Communicate communicate = new Communicate();
ConsoleCommunicator consoleCommunicator = new ConsoleCommunicator();
SpeechCommunicator speechCommunicator = new SpeechCommunicator();
//communicate.SendMessage("Hello C# is awesome", speechCommunicator);


//3
PetrolEngine petrolEngine = new PetrolEngine();
Beetle beetle = new Beetle(petrolEngine);

beetle.Start();
beetle.Accelerate();
//Console.WriteLine(beetle.EngineSize);



Guitar guitar1 = new Guitar() { Id = 1, Name = "Fender Stratocaster", Price = 1299M };
Guitar guitar2 = new Guitar() { Id=1, Name="Gibson SG", Price=1200.99M};
IProduct guitar3 = new Guitar() { Id =2, Name = "Fender Jaguar", Price = 899.99M };
IProduct drums1 = new Drums() { Id = 3, Name = "Pearl Export", Price = 1400.95M, ComesWithFreeSticks = true };

Basket basket = new Basket();

basket.AddProduct(guitar1);
basket.AddProduct(guitar2);
basket.AddProduct(guitar3);
basket.AddProduct(drums1);

Console.WriteLine(basket.BasketTotal);


// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
