using IOC.Repository;
using IOC.Repository.Instances;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC
{
    public class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection()
                .AddSingleton<ICollegeStudent, CollegeStudent>()
                .AddSingleton<ISchoolStudent, SchoolStudent>()
                .AddSingleton<IProcessData, ProcessData>()
                .BuildServiceProvider();


            var processData = serviceCollection.GetService<IProcessData>();

            processData.DisplayContent();

            Console.ReadLine();


        }
    }
}
