using System;

namespace IOC.Repository.Instances
{
    public class SchoolStudent: ISchoolStudent
    {
        public void PrintStudentDetails()
        {
            Console.WriteLine("Printing from Scool Student");
        }
    }
}