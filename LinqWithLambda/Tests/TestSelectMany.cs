using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLambda.Tests
{
    class TestSelectMany : ITest
    {
        public void Test()
        {
            var persons = new List<Person>();

            persons.Add(new Person
            {
                Id = 1,
                Name = "John",
                PersonPhones = new List<PersonPhone> { new PersonPhone { PhoneNumber = "123456" }, new PersonPhone { PhoneNumber = "1564561" } }
            });

            persons.Add(new Person
            {
                Id = 2,
                Name = "Mary",
                PersonPhones = new List<PersonPhone> { new PersonPhone { PhoneNumber = "7898452" }, new PersonPhone { PhoneNumber = "6423384" } }
            });

            var personPhones = persons.Select(p => p.PersonPhones);

            foreach (var item in personPhones)
            {
                foreach (var phone in item)
                {
                    Console.WriteLine(phone.PhoneNumber);
                }
            }

            string json = JsonConvert.SerializeObject(personPhones, Formatting.Indented);

            Console.WriteLine(json);
            Console.WriteLine();

            var phones = persons.SelectMany(p => p.PersonPhones);

            foreach (var item in phones)
            {
                Console.WriteLine(item.PhoneNumber);
            }

            string json1 = JsonConvert.SerializeObject(phones, Formatting.Indented);

            Console.WriteLine(json1);
        }

        class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public List<PersonPhone> PersonPhones { get; set; }
        }

        class PersonPhone
        {
            public string PhoneNumber { get; set; }
        }
    }
}
