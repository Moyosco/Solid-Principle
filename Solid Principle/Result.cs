using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle
{
    internal class Result : classdetails 
    {
        public string Grade()
        {
            try
            {
                if (Numberofstudents <= Numberofcourses )
                {
                    return "Student is Registered";
                }
                else if (Numberofstudents > Numberofcourses )
                {
                    return "Student not registered";
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
