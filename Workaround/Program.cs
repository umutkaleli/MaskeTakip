// See https://aka.ms/new-console-template for more information
using System;

using Business.Concrete;
using Entities.Concrete;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person
            {
                FirstName = "UMUT",
                LastName = "KALELİOĞLU",
                DateOfBirthYear = 2004,
                NationalIdentity = 1234
            };

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);
            

        }
    }
}
