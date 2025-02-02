using System;
public class Person{
     public string Name 
     {
         get; set; 
     }
     private int age;
     public int Age{
         get {return age;}
         set 
         {
             if (value<=0)
             {
                 throw new ArgumentException("Age must be a positive number.");
             }
             age=value;
         }
     }
}

class Program
{
    public static void Csharpproperties()
    {
    Console.WriteLine("Enter the person's name:");
    string name = Console.ReadLine();
    Console.Write("Enter the person's age:");
    int age = int.Parse(Console.ReadLine());
    /*if (!int.TryParse(Console.ReadLine(), out age))
        {
            Console.WriteLine("Invalid age input. Please enter a valid number.");
            return;
        }*/
    Person p=new Person();
    p.Name=name;
    try{
        p.Age=age;
    }catch (ArgumentException e){
        Console.WriteLine($"Error: {e.Message}");
        return;
    }
    Console.WriteLine($"Name: {p.Name} Age: {p.Age}");
    }
}
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    