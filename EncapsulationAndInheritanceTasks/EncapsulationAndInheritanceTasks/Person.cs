using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationAndInheritanceTasks
{
    public class Person
    {
        private string _fullName;
        private int _age;
        public double PhoneNumber;


        public string FullName
        {
            get { return _fullName; }
            set
            {
                string fullNameVal = value;
                fullNameVal = fullNameVal.Trim();

                for (int i = 0; i < fullNameVal.Length; i++)
                {
                    if (fullNameVal[i] == ' ')
                    {
                        if (char.IsUpper(fullNameVal[i + 1]) && char.IsUpper(fullNameVal[0]))
                        {
                            this._fullName = fullNameVal;
                            break;
                        }
                    }
                }
            }
        }
        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 0)
                {
                    this._age = value;
                }
                else
                {
                    Console.WriteLine("Age deyeri menfi ola bilmez");
                }

            }
        }
        

        public Person(string fullName, int age, double phoneNumber)
        {
            this.FullName = fullName;
            this.Age = age;
            this.PhoneNumber = phoneNumber;
        }
        public void showAllData()
        {
            Console.WriteLine($"FullName: {FullName} Age: {Age} PhoneNumber: {PhoneNumber}");
        }
    }
}
