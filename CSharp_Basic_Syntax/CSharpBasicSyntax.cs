using System;
class CSharpBasicSyntax {
  static void Main() {
    const string username="Alice";
    const string password="Wonderland123";
    Console.WriteLine("Enter your username:");
    string name=Console.ReadLine();
    if (name==""){
        throw new Exception("username cannot be empty");
    }
    Console.WriteLine("Enter your password:");
    string pwd=Console.ReadLine();
     if (pwd==""){
        throw new Exception("password cannot be empty");
    }
    if(username==name && pwd==password){
        Console.WriteLine($"Welcome {username}! You have successfully logged in.");
    }
    else{
        Console.WriteLine("Login failed. Please check your username and password.");
    }
  }
}