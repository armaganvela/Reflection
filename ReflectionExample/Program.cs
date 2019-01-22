using FactoryDbProvider;
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
            IRepository personRepository = Provider.GetDbProvider();
        }
    }
}

