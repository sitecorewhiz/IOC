using System;

namespace IOC.Repository.Instances
{
    public class CollegeStudent : ICollegeStudent
    {
        public void PrintCollegeStudentDetails()
        {
            Console.WriteLine("Printing from College Student");
        }
    }
}