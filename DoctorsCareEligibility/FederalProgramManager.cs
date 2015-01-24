using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;


namespace DoctorsCareEligibility
{
    class FederalProgramManager
    {
        public string FederalProgramsFilePath { get; set; }
        public FederalProgramManager()
        {
        }

        public List<FederalProgram> getListOfAllFederalPrograms()
        {
            List<FederalProgram> programlist = new List<FederalProgram>();
            List<int> agelist = new List<int>();
            List<string> ImmigrationStatus = new List<string>();


            FederalProgram wic = new FederalProgram();
            agelist.Add(0);
            agelist.Add(5);
            wic.ChildAges= agelist;
            wic.NameOfProgram = "WIC";
            wic.MaxLevelOfFederalPoverty = 185;
            wic.ImmigrationStatus = null;
            wic.Notes = "Must be pregnant or have dependent child 5 or under. Fathers may apply.";
            wic.linkToForm = "https://www.colorado.gov/cdphe/new-to-wic";
            programlist.Add(wic);

            FederalProgram LEAP = new FederalProgram();
            agelist.Clear();
            agelist.Add(6);
            LEAP.ChildAges = agelist;
            ImmigrationStatus.Add("USCITIZEN");
            ImmigrationStatus.Add("LEGALRESIDENT");
            LEAP.ImmigrationStatus = ImmigrationStatus;
            LEAP.NameOfProgram = "LEAP";
            LEAP.MaxLevelOfFederalPoverty = 185;
            LEAP.linkToForm = "http://www.colorado.gov/cs/Satellite?c=Page&childpagename=CDHS-SelfSuff%2FCBONLayout&cid=1251585703329&pagename=CBONWrapper";
            programlist.Add(LEAP);

            FederalProgram CCAP = new FederalProgram();
            agelist.Clear();
            agelist.Add(6);
            agelist.Add(0);
            agelist.Add(18);
            CCAP.MaxLevelOfFederalPoverty = 185;
            CCAP.NameOfProgram = "CCAP";
            CCAP.ChildAges = agelist;
            CCAP.Notes = "Children must be legal residents, but do not need to meet the 5 year bar requirement, however parents do not have to have legal residency to apply";
            CCAP.linkToForm = "http://www.coloradoofficeofearlychildhood.com/#!cccap-parents/c8yy";
            programlist.Add(CCAP);

            FederalProgram Weatherization = new FederalProgram();
            ImmigrationStatus.Clear();
            ImmigrationStatus.Add("USCITIZEN");
            Weatherization.ImmigrationStatus = ImmigrationStatus;
            Weatherization.MaxLevelOfFederalPoverty = 185;
            Weatherization.NameOfProgram = "Weatherization";
            Weatherization.Notes = "If client is the home owner then furnace and refrigerator repair is free. If client is renting their home, the landlord is asked to pay half of the furnace/refrigerator repair costs, if they choose not to the renter may pay himself. If the client is living in a fourplex, two of the complexes must qualify for weatherization. Large apartment buildings are evaluated on a case by case basis.";
            Weatherization.linkToForm = "http://www.colorado.gov/cs/Satellite/GovEnergyOffice/CBON/1251597631693";
            programlist.Add(Weatherization);

            FederalProgram internetEssentials = new FederalProgram();
            internetEssentials.MaxLevelOfFederalPoverty = 185;
            internetEssentials.NameOfProgram = "Internet Essentials";
            internetEssentials.Notes = "Must have at least one child that qualifies for the National School Lunch Program; must not have subscribed to Comcast in the last 90 days; must not have overdue Comcast bills/unreturned equipment";
            internetEssentials.linkToForm = "http://www.internetessentials.com/";
            programlist.Add(internetEssentials);

            FederalProgram TANF = new FederalProgram();
            agelist.Clear();
            agelist.Add(19);
            TANF.ChildAges = agelist;
            TANF.NameOfProgram = "TANF";
            TANF.MaxLevelOfFederalPoverty = 185;
            TANF.ImmigrationStatus = ImmigrationStatus;
            TANF.linkToForm = "http://www.colorado.gov/cs/Satellite?c=Page&childpagename=CDHS-ColoradoWorks%2FCCWLayout&cid=1251575352172&pagename=CCWWrapper";
            programlist.Add(TANF);

            FederalProgram foodAssistance = new FederalProgram();
            foodAssistance.MaxLevelOfFederalPoverty = 130;
            foodAssistance.NameOfProgram = "Food Assistance";
            foodAssistance.Notes = "There have been cases where households with illegal parents, but legal children qualified for assistance.";
            foodAssistance.linkToForm = "http://www.colorado.gov/cs/Satellite/CDHS-SelfSuff/CBON/1251582131809";
            programlist.Add(foodAssistance);

            FederalProgram fccLifeLine = new FederalProgram();
            fccLifeLine.ImmigrationStatus = ImmigrationStatus;
            fccLifeLine.MaxLevelOfFederalPoverty = 185;
            fccLifeLine.NameOfProgram = "FCC Life Line Assistance";
            fccLifeLine.linkToForm = "http://www.fcc.gov/lifeline";
            programlist.Add(fccLifeLine);

            return programlist;
        }

        
    }
}
