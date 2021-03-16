using CampusMindsBL;
using System;

//using Exceptions;
using System.Data;

namespace CampusMindsPL
{
    internal class CampusMindsPLClass
    {
        public static void Main(string[] args)
        {
            int choiceMenu = 0;
            int choiceProg = 0;

            do
            {
                Console.WriteLine("=======================================================================================");
                Console.WriteLine("\t\tCAMPUS MINDS MANAGEMENT SYSTEM");
                Console.WriteLine("======================================================================================");
                Console.WriteLine("Press 1 to Get list of Technologies and Leads and show candidates");
                Console.WriteLine("Press 2 to Count of Candidates in Technologies and count no of Candidates in Leads.");
                Console.WriteLine("Press 3 to Get List Min 3 Candidates based on Technology.");
                Console.WriteLine("Press 4 to Get Lead Name who is having Maximum no Candidates.");
                Console.WriteLine("Press 5 to Exit");
                Console.WriteLine("=======================================================================================");
                Console.WriteLine("Enter Your Choice:");

                try
                {
                    choiceMenu = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }

                CampusMindsBLClass campusMindsBLClassObj = new CampusMindsBLClass();
                PrintData printDataObj = new PrintData();

                switch (choiceMenu)
                {
                    case 1:
                        DataTable datatableTechnologies = campusMindsBLClassObj.GetDetailsOfTechnologies();

                        DataTable datatableLeads = campusMindsBLClassObj.GetDetailsOfLeads();

                        DataTable datatableCandidates = campusMindsBLClassObj.GetDetailsOfCandidates();

                        printDataObj.PrintDetailOfTechnologies(datatableTechnologies);
                        printDataObj.PrintDetailsOfLeads(datatableLeads);
                        printDataObj.PrintDetailsOfCandidates(datatableCandidates);

                        //TO Print Leads

                        //To Print Candidates

                        break;

                    case 2:

                        DataTable datatableCountCandidatesInLeads = campusMindsBLClassObj.GetCountCandidatesInLeads();

                        DataTable datatableCountCandidatesInTechnology = campusMindsBLClassObj.GetCountCandidatesInTechnology();

                        printDataObj.PrintCountCandidatesInLeads(datatableCountCandidatesInLeads);
                        printDataObj.PrintCountCandidatesInTechnology(datatableCountCandidatesInTechnology);

                        break;

                    case 3:

                        DataTable dtblGetTechnologyHavingCandidates = campusMindsBLClassObj.GetTechnologyHavingCandidates();

                        printDataObj.CountTechnologyHavingCandidates(dtblGetTechnologyHavingCandidates);

                        break;

                    case 4:

                        DataTable dtblGetLeadWithMaxCandidates = campusMindsBLClassObj.GetLeadWithMaxCandidates();

                        printDataObj.PrintLeadWithMaxCandidates(dtblGetLeadWithMaxCandidates);

                        break;

                    case 5:
                        Console.WriteLine("Exiting.....");
                        return;

                    default:
                        Console.WriteLine("Wrong Choice....");
                        break;
                }

                Console.WriteLine("Press 1 to Continue...");
                try
                {
                    choiceProg = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (choiceProg == 1);
        }
    }
}