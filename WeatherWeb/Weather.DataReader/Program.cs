// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World
//

using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using Weather.Core.Services;
using Weather.Core.Services.Interfaces;

namespace Weather.DataReader // Note: actual namespace depends on the project name.
{
    class Program
    {      
        static void Main(string[] args)
        {

            
            new Client().Run();


            //save weathers

            Console.ReadKey();         
        }

    }
}


