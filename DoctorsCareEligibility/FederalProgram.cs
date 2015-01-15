using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorsCareEligibility
{
    class FederalProgram
    {
        //These are nullable since there may not be a requirement that matches them.  In that case, 
        //there will be a null.
        public List<string> ImmigrationStatus { get; set; }
        public int? MaxLevelOfFederalPoverty { get; set; }
        public List<int> ChildAges { get; set; }
        public string NameOfProgram { get; set; }
        public string Notes { get; set; }

        public FederalProgram()
        {
        }
    }
}
