namespace KESCHA.Classes
{
  class Animal
  {
    public int Age { get; set; }
    public string Name { get; set; }
    public int AgeDifference { get; set; }

    public Animal()
    {
      Age = 0;
      Name = "No name";
      AgeDifference = 0;
    }
    public Animal(string name, int age)
    {
      Name = name;
      Age = age;
    }

    public Animal(
      string name,
      int userAge,
      int animalAge)
    {
      Name = name;
      Age = animalAge;
      CalculateAgeDifferenceWithNoReturn(userAge, animalAge);
    }

    public void PrintAgeDifference()
    {
      Console.WriteLine($"Siznign va {Name}ning yoshi orasidagi farq : {AgeDifference}");
    }

    public void CompareAges(int userAge)
    {
      if (userAge > Age)
      {
        Console.WriteLine("Sizning yoshingiz keschanikidan katta ");
      }
      else if (userAge == Age)
      {
        Console.WriteLine("Sizning yoshingiz keschanikiga teng");
      }
      else
      {
        Console.WriteLine("Sizning yoshingiz keschanikidan kichik");
      }
    }

    public void TellAboutFriends(string userName, int userAge)
    {
      System.Console.WriteLine("Let me tell about my friend");
      string[] friendsName = new string[3];
      friendsName[0] = "Kasee";
      friendsName[1] = "Vasya";
      friendsName[2] = userName;
      int[] friendsAge = { 1, 2, userAge };
      for (int i = 0; i < friendsName.Length; i++)
      {
        System.Console.WriteLine($"{friendsName[i]} is {friendsAge[i]} years old!");
      }
    }
    public void Greet(string userName)
    {
      if (userName == string.Empty)
      {
        userName = "Unknow Person";
      }
      System.Console.WriteLine($"Hello {userName}");
    }
    public void CalculateAgeDifferenceWithNoReturn(int userAge)
    {
      AgeDifference = userAge - Age;
    }
    private int CalculateAgeDifference(int userAge, int animalAge)
    {
      return userAge - animalAge;
    }
    private void CalculateAgeDifferenceWithNoReturn(int userAge, int animalAge)
    {
      AgeDifference = userAge - animalAge;
    }

  }
}