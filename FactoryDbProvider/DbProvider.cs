﻿using PersonRepository.Interface;
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
        public static IRepository GetDbProvider()
        {
            var providerName = "PersonRepository.SQLServer";

            Assembly assembly = Assembly.LoadFrom(@"C:\Users\Furkan\Documents\GitHub\Reflection\PersonRepository.SQLServer\bin\Debug\PersonRepository.SQLServer.dll");

            return (IRepository)assembly.CreateInstance(providerName + "." + "SqlRepository");
        }
    }
}
