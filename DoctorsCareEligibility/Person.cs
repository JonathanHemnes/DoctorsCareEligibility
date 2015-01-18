using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorsCareEligibility
{
    class Person
    {
        public bool isExemptFrom5YearLimit { get; set; }
        public int amountOfFederalPovertyLevel { get; set; }

        public List<int> agesOfChildren { get; set; }
        public int numberOfFamilyMembers { get; set; }
        public string residencyStatus { get; set; }

        public Person(
             
            int _yearlyIncome,
            int _numberOfFamilyMembers,
            List<int> _agesOfChildren,
            string _residencyStatus
            )
        {
            
            amountOfFederalPovertyLevel = getFPL(_yearlyIncome, _numberOfFamilyMembers);
            numberOfFamilyMembers = _numberOfFamilyMembers;
            agesOfChildren = _agesOfChildren;
            residencyStatus = _residencyStatus;
            
        }

        private int getFPL(int income, int familyMembers)
        {
            int fpl;
            int baseFPLIncome = 11670;
            int perPersonIncrease = 4060;

            fpl = (income*100) / (baseFPLIncome + (familyMembers * perPersonIncrease));
            return fpl;
        }

    }
}
