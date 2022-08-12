using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle
{
    internal class Studentdetails
    {

        public string Name { get; set; }    
        public string Email { get; set; }   
        public int Matricnumber { get; set; }
        public bool Isstudent { get; set; }
        public bool studentvalidator()
        {
            try
            {
                if (Isstudent)
                {
                    return true;

                }
                else
                {
                    return false;
                }
                  
            }
            catch (Exception)
            {

                throw;
            }
        }
       

    }
}
