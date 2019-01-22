using FactoryDbProvider;
using PeopleViewer.SharedObjects;
using PersonRepository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            IPersonRepository personRepository = Provider.GetDbProvider();

            personRepository.Add(new Person() { });
        }
    }
}

