using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Encapsulation_Access_Modifiers
{
    class Person
    {
        internal string name;
        private protected string surname;
        protected string Address { get; set; }
        public string Color { get; set;  }
        private int _age;



        public int Age { 
            get
            {
                if (_age < 18)
                {
                    Console.WriteLine("Can't see");
                    return -1;
                }
                return _age;
            }

            set
            {
                _age = value;
            } 
        }
        
        
       //public int Name { get; set; }
       //public int Surname { get; set; }
    }


    
    
}
