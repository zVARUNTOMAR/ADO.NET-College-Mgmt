using Exceptions;
using System.Linq;
using System.Data;
using CampusMindsDL;
using System;

namespace CampusMindsBL
{
    public class CampusMindsBLClass
    {
        //TO Validate Name
        public void isNameValid(string name)
        {
            bool conatinsInt = name.Any(char.IsDigit);

            if (conatinsInt == true)
            {
                throw new InvalidNameException("Invalid Name..");
            }
        }

        //TO Get Details of Technologies
        public DataTable GetDetailsOfTechnologies() {

            CampusMindsDLClass campusMindsDLClassObj = new CampusMindsDLClass();

            DataTable datatableTechnologies = campusMindsDLClassObj.GetDetailsOfTechnologies();

            return datatableTechnologies;

        }

        //To Get Details of Leads
        public DataTable GetDetailsOfLeads()
        {

            CampusMindsDLClass campusMindsDLClassObj = new CampusMindsDLClass();

            DataTable datatableLeads = campusMindsDLClassObj.GetDetailsOfLeads();

            return datatableLeads;

        }

        //To Get Details of Technologies
        public DataTable GetDetailsOfCandidates() {

            CampusMindsDLClass campusMindsDLClassObj = new CampusMindsDLClass();

            DataTable datatableCandidates = campusMindsDLClassObj.GetDeatilsOfCandidates();

            return datatableCandidates;

        }


        //To Get Count of Candidates in Each Technology
        public DataTable GetCountCandidatesInTechnology() {

            CampusMindsDLClass campusMindsDLClassObj = new CampusMindsDLClass();

            DataTable datatableCountCandidatesInTechnology = campusMindsDLClassObj.GetCountCandidatesInTechnology();

            return datatableCountCandidatesInTechnology;

        }

        //To Get Count Candidates in Leads
        public DataTable GetCountCandidatesInLeads() {

            CampusMindsDLClass campusMindsDLClassObj = new CampusMindsDLClass();

            DataTable datatableCountCandidatesInLeads = campusMindsDLClassObj.GetCountCandidatesInLeads();

            return datatableCountCandidatesInLeads;
        }

        public DataTable GetTechnologyHavingCandidates()
        {

            CampusMindsDLClass campusMindsDLClassObj = new CampusMindsDLClass();

            DataTable datatableTechnologyHavingCandidates = campusMindsDLClassObj.GetTechnologyHavingCandidates();

            return datatableTechnologyHavingCandidates;
        }

        public DataTable GetLeadWithMaxCandidates()
        {
            CampusMindsDLClass campusMindsDLClassObj = new CampusMindsDLClass();

            DataTable datatableLeadWithMaxCandidates = campusMindsDLClassObj.GetLeadWithMaxCandidates();

            return datatableLeadWithMaxCandidates;

        }
    }
}