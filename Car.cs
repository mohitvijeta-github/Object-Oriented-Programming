using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming
{
    internal class Pet
    {
        private string _size;
        private string _type;
        private int _age;
        public Pet()
        {
            Console.WriteLine("Hi, there Welcome to Pet Shop");
        }
        public void PetSize(string size)
        {
            _size = size;
            Console.WriteLine("Here is "+ size +"  "+ _type);
        }
        public string BodyType { get { return _type; } set { _type = value; } }

        public void Categroy(string type)
        {
            type = "dmall";
             _type = type;
            Console.WriteLine("Here: " +type);
        }
        public void age(int age)
        {
            _age = age;
            Console.WriteLine("Here is: "+age);
        }
    }

}
