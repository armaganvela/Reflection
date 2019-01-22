using PersonRepository.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDbProvider
{
    public static class Provider
    {
        public static IPersonRepository GetDbProvider()
        {
            var providerName = "PersonRepository.SQLServer";

            Assembly assembly = Assembly.LoadFrom(@"C:\Users\Furkan\source\repos\ReflectionExample\PersonRepository.SQLServer\bin\Debug\PersonRepository.SQLServer.dll");

            return (IPersonRepository)assembly.CreateInstance(providerName + "." + "SqlRepository");
        }
    }
}
