using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC.Repository
{
    public class ProcessData : IProcessData
    {

        private ICollegeStudent _collegeStudent;

        private ISchoolStudent _schoolStudent;

        public ProcessData(ICollegeStudent collegeStudent, ISchoolStudent schoolStudent)
        {
            _collegeStudent = collegeStudent;
            _schoolStudent = schoolStudent;
        }


        public void DisplayContent()
        {
            //CollegeStudent collStud = new CollegeStudent();

            //SchoolStudent schoolStud = new SchoolStudent();


            _collegeStudent.PrintCollegeStudentDetails();

            _schoolStudent.PrintStudentDetails();

        }
    }
}
