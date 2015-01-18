using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorsCareEligibility
{
    class PersonToProgramComparer
    {
        public List<FederalProgram> listOfPotentialFederalPrograms { get; set; }
        public Person personToCompareToFederalPrograms { get; set; }
        public PersonToProgramComparer(List<FederalProgram> _listOfFederalPrograms, Person _person)
        {
            this.listOfPotentialFederalPrograms = _listOfFederalPrograms;
            this.personToCompareToFederalPrograms = _person;
        }
        public Boolean comparePersonToFederalProgram(FederalProgram program, Person person)
        {
            Boolean matchesAllRequirements = false;
            if(meetsChildAgeRequirements(program,person) 
                && meetsFPLRequirement(program,person) 
                && meetsImmigrationStatusRequirement(program,person))
            {
                matchesAllRequirements = true;
            };

            return matchesAllRequirements;
        }

        private Boolean meetsChildAgeRequirements(FederalProgram program, Person person)
        {
            Boolean doesMeetChildAgeRequirement = false;

            return doesMeetChildAgeRequirement;

        }
        private Boolean meetsFPLRequirement(FederalProgram program, Person person)
        {
            Boolean doesMeetFPLRequirement = false;

            return doesMeetFPLRequirement;
        }
        private Boolean meetsImmigrationStatusRequirement(FederalProgram program, Person person)
        {
            Boolean doesMeetImmigrationStatusRequirement = false;

            return doesMeetImmigrationStatusRequirement;
        }

    }
}
