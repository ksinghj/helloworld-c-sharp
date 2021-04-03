using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var Kartar = new Person();

            Kartar.FirstName = "Kartar";
            Kartar.LastName = "Singh";

            Kartar.SayName();
        }
    }
}
