using System;
using System.Data;

namespace CampusMindsPL
{
    internal class PrintData
    {
        internal void PrintDetailOfTechnologies(DataTable datatableTechnologies)
        {
            Console.WriteLine("=======================================================================================");
            Console.WriteLine("\tTECHNOLOGIES");
            Console.WriteLine("=======================================================================================");
            Console.WriteLine("TechID|\tName|\tDescription");

            foreach (DataRow datarow in datatableTechnologies.Rows)
            {
                Console.WriteLine("|{0}\t|{1}|\t{2}", (int)datarow["TechID"], (string)datarow["Name"], (string)datarow["Description"]);
            }
            Console.WriteLine("=======================================================================================");
        }

        internal void PrintDetailsOfLeads(DataTable datatableLeads)
        {
            Console.WriteLine("=======================================================================================");
            Console.WriteLine("\tLEADS");
            Console.WriteLine("=======================================================================================");
            Console.WriteLine("LeadID|\tName|\tTechID");

            foreach (DataRow datarow in datatableLeads.Rows)
            {
                Console.WriteLine("|{0}\t|{1}|\t{2}", (int)datarow["LeadID"], (string)datarow["Name"], (int)datarow["TechID"]);
            }
            Console.WriteLine("=======================================================================================");
        }

        internal void PrintDetailsOfCandidates(DataTable datatableCandidates)
        {
            Console.WriteLine("=======================================================================================");
            Console.WriteLine("\tCANDIDATES");
            Console.WriteLine("=======================================================================================");
            Console.WriteLine("CandidateID|\tName|\tLeadID");

            foreach (DataRow datarow in datatableCandidates.Rows)
            {
                Console.WriteLine("|{0}\t|{1}|\t{2}", (int)datarow["CandidateID"], (string)datarow["Name"], (int)datarow["LeadID"]);
            }
            Console.WriteLine("=======================================================================================");
        }

        internal void PrintCountCandidatesInLeads(DataTable datatableCountCandidatesInLeads)
        {
            Console.WriteLine("=======================================================================================");
            Console.WriteLine("\tCOUNT CANDIDATES IN TECHNOLOGY");
            Console.WriteLine("=======================================================================================");
            Console.WriteLine("|Name|\tCount");
            foreach (DataRow datarow in datatableCountCandidatesInLeads.Rows)
            {
                Console.WriteLine("|{0}\t|{1}|", (int)datarow["LeadID"], (int)datarow["TotalCandidates"]);
            }
            Console.WriteLine("=======================================================================================");
        }

        internal void CountTechnologyHavingCandidates(DataTable dtblGetTechnologyHavingCandidates)
        {
            Console.WriteLine("=======================================================================================");
            Console.WriteLine("\tTECHNOLOGIES HAVING MORE THAN 3 CANDIDATES");
            Console.WriteLine("=======================================================================================");

            foreach (DataRow datarow in dtblGetTechnologyHavingCandidates.Rows)
            {
                Console.WriteLine("|{0}\t|{1}|", (string)datarow["Name"], (int)datarow["Total_Candidates"]);
            }
            Console.WriteLine("=======================================================================================");
        }

        internal void PrintLeadWithMaxCandidates(DataTable dtblGetLeadWithMaxCandidates)
        {
            Console.WriteLine("=======================================================================================");
            Console.WriteLine("\tLEAD HAVING MAX CANDIDATES");
            Console.WriteLine("=======================================================================================");
            Console.WriteLine("LeadID|\tName|\tTotalCandidates");
            foreach (DataRow datarow in dtblGetLeadWithMaxCandidates.Rows)
            {
                Console.WriteLine("|{0}\t|{1}\t|{2}", (int)datarow["LeadID"], (string)datarow["name"], (int)datarow["TotalCandidates"]);
            }

            Console.WriteLine("=======================================================================================");
        }

        internal void PrintCountCandidatesInTechnology(DataTable datatableCountCandidatesInTechnology)
        {
            Console.WriteLine("=======================================================================================");
            Console.WriteLine("\tCoUNT CANDIDATES IN LEADS");
            Console.WriteLine("=======================================================================================");
            Console.WriteLine("LeadID|\tTotalCandidates");
            foreach (DataRow datarow in datatableCountCandidatesInTechnology.Rows)
            {
                Console.WriteLine("|{0}\t|{1}|", (string)datarow["Name"], (int)datarow["Total_Candidates"]);
            }
            Console.WriteLine("=======================================================================================");
        }
    }
}