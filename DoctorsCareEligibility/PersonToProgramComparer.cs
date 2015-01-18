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
        public List<FederalProgram> getProgramMatchesForPerson()
        {
            List<FederalProgram> programMatches = new List<FederalProgram>() ;

            foreach (FederalProgram program in listOfPotentialFederalPrograms)
            {
                if (comparePersonToFederalProgram(program,personToCompareToFederalPrograms))
                {
                    programMatches.Add(program);
                }
            }
            return programMatches;
        }
        private Boolean comparePersonToFederalProgram(FederalProgram program, Person person)
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

            if (program.ChildAges.Count == null)
            {
                doesMeetChildAgeRequirement = true;
            }
            else
            {
                foreach (int requiredProgramAge in program.ChildAges)
                {
                    foreach (int ageOfPersonsChild in person.agesOfChildren)
                    {
                        if (ageOfPersonsChild <= requiredProgramAge)
                        {
                            doesMeetChildAgeRequirement = true;
                        }
                    }
                }
            }
            return doesMeetChildAgeRequirement;

        }
        private Boolean meetsFPLRequirement(FederalProgram program, Person person)
        {
            Boolean doesMeetFPLRequirement = false;

            if (person.amountOfFederalPovertyLevel < program.MaxLevelOfFederalPoverty)
            {
                doesMeetFPLRequirement = true;
            }

            return doesMeetFPLRequirement;
        }
        private Boolean meetsImmigrationStatusRequirement(FederalProgram program, Person person)
        {
            Boolean doesMeetImmigrationStatusRequirement = false;
            if (program.ImmigrationStatus.Count == null)
            {
                doesMeetImmigrationStatusRequirement = true;
            }
            else
            {
                foreach (String immigrationStatus in program.ImmigrationStatus)
                {
                    if (person.residencyStatus.ToUpper() == immigrationStatus.ToUpper())
                    {
                        doesMeetImmigrationStatusRequirement = true;
                    }
                }
            }

            return doesMeetImmigrationStatusRequirement;
        }

    }
}
