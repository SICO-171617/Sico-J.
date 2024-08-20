// See https://aka.ms/new-console-template for more information


// This is the Code where the user inputs their name
Console.Write("Enter your name: ");
string userName = Console.ReadLine();

// This part is where they enter the number of their enrolled classes
Console.Write("Enter the number of your enrolled subject: ");
int enrolled_sub;
enrolled_sub = Convert.ToInt32(Console.ReadLine()); //This converts int to string, making it possible to appear in the console

//This is where the user inputs the price of their favorite book
Console.Write("Enter the price of your favorite book: ");
float fave_book_price; //Since prices are usually have decimal points, I used float to make the decimals appear
fave_book_price = Convert.ToSingle(Console.ReadLine()); //But to make it appear int the console, I must use ToSingle instead of ToInt32

//This what makes my code appear in the console
Console.WriteLine("Hi! Your name is: " + userName);
Console.WriteLine("You are enrolled in " + enrolled_sub + " subjects");
Console.WriteLine("Your favorite book cost : " + fave_book_price);
Console.WriteLine("\nPress any key to continue");
Console.ReadKey();

