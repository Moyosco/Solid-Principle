using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle
{
    internal class Paymentvalidation : classdetails  //instanciating class
    {
        private int Numberofstudent;

        public string Paymentdetails { get; set; }   
        public string Score()
        {     
            try
             {
                if (Numberofstudent >= Numberofcourses)
                {
                    return "You are registered with the school";
                }
                else if (Numberofstudents > Numberofcourses)
                {
                    return "You are not registered with the school";
                }
            }
            catch (Exception)
            {

                return "error";
            }
        }
        
    }
}
