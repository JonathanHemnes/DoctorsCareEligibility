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
        enum residencyStatus
        {
            citizenOrLegalResident,
            legalResidentUnder5YearBar,
            illegalResident
        }
        public int amountOfFederalPovertyLevel { get; set; }
        public bool doesNotHaveChildren { get; set; }
        public bool hasChild0to5 { get; set; }
        public bool hasChild5to6 { get; set; }
        public bool hasChild6to12 { get; set; }
        public bool hasChild13to18 { get; set; }
        public bool isPregnant { get; set; }
        public int numberOfFamilyMembers { get; set; }


        public Person(
            bool _isExemptFrom5yrLimit, 
            int _yearlyIncome,
            int _numberOfFamilyMembers,
            bool _doesNotHaveChildren,
            bool _hasChild0to5,
            bool _hasChild5to6,
            bool _hasChild6to12,
            bool _hasChild13to18,
            bool _isPregnant)
        {
            isExemptFrom5YearLimit = _isExemptFrom5yrLimit;
            amountOfFederalPovertyLevel = getFPL(_yearlyIncome, _numberOfFamilyMembers);
            doesNotHaveChildren = _doesNotHaveChildren;
            hasChild0to5 = _hasChild0to5;
            hasChild5to6 = _hasChild5to6;
            hasChild6to12 = _hasChild6to12;
            hasChild13to18 = _hasChild13to18;
            isPregnant = _isPregnant;
            numberOfFamilyMembers = _numberOfFamilyMembers;
            
        }

        private int getFPL(int income, int familyMembers)
        {
            int fpl;
            int baseFPLIncome = 11670;
            int perPersonIncrease = 4060;

            fpl = income / (baseFPLIncome + familyMembers * perPersonIncrease);
            return fpl;
        }

    }
}
