System.Console.WriteLine("KESCHA dasturiga xush kelibsiz :)");
int ageKESCHA = 2;
System.Console.Write("Enter your name : ");
string name = Console.ReadLine();
System.Console.WriteLine($"Hello, {name}");

System.Console.Write("Enter your age : ");
int age = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Your age is {age}");
System.Console.WriteLine($"KESCHA age is {ageKESCHA}");

System.Console.WriteLine($"Age difference is {age-ageKESCHA}");

System.Console.WriteLine($"KESCHA {name}dan katta : {ageKESCHA>age}");
System.Console.WriteLine($"KESCHA {name}dan kichik : {ageKESCHA<age}");
System.Console.WriteLine($"KESCHA {name}dan katta yoki teng : {ageKESCHA>=age}");
System.Console.WriteLine($"KESCHA {name}dan kichik yoki teng : {ageKESCHA<=age}");
System.Console.WriteLine($"KESCHA {name}ga teng : {ageKESCHA==age}");
System.Console.WriteLine($"KESCHA {name}ga teng ema : {ageKESCHA!=age}");