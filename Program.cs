using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Member member1 = new Member();
            member1.Introducing(true);
            Console.ReadKey();
        }
    }
}



//Pet var= new Pet();

// Console.WriteLine(var.BodyType); 

// Console.Write("Want to access the shop press the number below: ");
// Console.WriteLine("1: Dog " + " 2: Cat  " + " 3: Parrot  " + "4: Rabbit");

// string input1 = Console.ReadLine(); 
// int input =int.Parse(input1);   

// if(input == 1)
// {
//     var.Categroy("Dog");
//     Console.WriteLine("Press S - Small , M - Medium , L - Large");

//     string input2= Console.ReadLine();
//     if (input2 == "S") {
//         var.PetSize("Small");
//     }
//     else if(input2 == "M")
//     {
//         var.PetSize("Medium");
//     }
//     else if (input2 == "L")
//     {
//         var.PetSize("Large");
//     }
//     else
//     {
//         Console.WriteLine("Invalid check again!");
//     }

// }
// else if(input == 2)
// {
//     var.Categroy("Cat");
// }
// else if (input == 3)
// {
//     var.Categroy("Parrot");
// }
// else if (input == 4)
// {
//     var.Categroy("Rabbit");
// }
// else
// {
//     Console.WriteLine("Invalid Entry: Please press right number. ");

// }

