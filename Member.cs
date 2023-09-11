using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming


{
    internal class Member
    {
        private string _JobTitle;
        private string _Name;
        private int _age;
        private int salary;


        private string jobTitle { get { return _JobTitle; } set { _JobTitle = value; } }

        public void Introducing (bool isFriend) 
        {
            if (isFriend) 
            {
                SharingPrivateInfo();
            
            }
            else 
            {
                Console.WriteLine("My name is: {0} , My age is : {1}, My Job is : {2}"+ _Name, _age , _JobTitle);
            }
        }
        private void SharingPrivateInfo()
        {
            Console.WriteLine("My salary is : " + salary);

        }
        public Member()
        {
            _age = 22;
            _JobTitle = "Software Engineer";
            _Name = "Mohit Vijeta";
            salary = 79000;

        }
        ~Member()
        {
            Console.WriteLine("");
            Debug.WriteLine("Destruction of Member Object");

        }



    }






}
