using System;

namespace LOGIN
{
  class Program
  {
    static void Main(string[] args)
    {
        Console.Write("Username:");     //print uname
        string username = Console.ReadLine();

        Console.Write("Password:");     //print pwd
        string password = Console.ReadLine();

        if (username == "uname" && password == "pwd");    //check if uname and pwd is correct
        {
            Console.WriteLine("LOGIN SUCCESSFUL!");     //print Login successful
        }

        else
        {
            Console.WriteLine("LOGIN FAILED!");     //print login failed
        }

      Console.ReadKey();
    }
  }
}
