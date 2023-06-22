using KESCHA.Classes;

Animal kescha = new Animal(name: "KESCHA",age: 3);

Console.Write("Enter your name : ");
string userName = Console.ReadLine();
kescha.Greet(userName);

Console.Write("Enter your age : ");
string ageAsString = Console.ReadLine();

Console.WriteLine("Converting...");
int userAge = Convert.ToInt32(ageAsString);
Console.WriteLine($"Successfully converted! {userAge}");

kescha.CalculateAgeDifferenceWithNoReturn(userAge);
kescha.PrintAgeDifference();
kescha.CompareAges(userAge);
kescha.TellAboutFriends(userName, userAge);