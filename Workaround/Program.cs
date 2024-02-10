using Business.Concrete;
using Entities.Concrete;

Person person1 = new Person();
person1.FirstName = "BÜŞRA";
person1.LastName = "ŞAHİN";
person1.DateOfBirthYear = 1998;
person1.NationalIdentity = 123; //fake



PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);

Console.ReadLine(); 