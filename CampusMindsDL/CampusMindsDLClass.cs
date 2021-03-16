using System;
using System.Data;
using System.Data.SqlClient;

namespace CampusMindsDL
{
    public class CampusMindsDLClass
    {
        private static string _connectionString = Properties.Settings.Default.connectionString;

        public DataTable GetDetailsOfTechnologies()
        {
            DataTable datatableTechnologies = new DataTable();

            try
            {
                SqlConnection sqlConn = new SqlConnection(_connectionString);
                sqlConn.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from Techonologies;", sqlConn);
                sqlDataAdapter.Fill(datatableTechnologies);
                sqlConn.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return datatableTechnologies;
        }

        public DataTable GetDetailsOfLeads()
        {
            DataTable datatableLeads = new DataTable();

            try
            {
                SqlConnection sqlConn = new SqlConnection(_connectionString);
                sqlConn.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(@"select * from Leads;", sqlConn);
                sqlDataAdapter.Fill(datatableLeads);
                sqlConn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return datatableLeads;
        }

        public DataTable GetDeatilsOfCandidates()
        {
            DataTable datatableCandidates = new DataTable();

            try
            {
                SqlConnection sqlConn = new SqlConnection(_connectionString);
                sqlConn.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(@"select * from candidates", sqlConn);
                sqlDataAdapter.Fill(datatableCandidates);
                sqlConn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return datatableCandidates;
        }

        public DataTable GetCountCandidatesInTechnology()
        {
            DataTable datatableCountCandidatesInTechnology = new DataTable();

            try
            {
                SqlConnection sqlConn = new SqlConnection(_connectionString);
                sqlConn.Open();

                SqlCommand sqlComm = new SqlCommand();

                sqlComm.CommandType = CommandType.StoredProcedure;
                sqlComm.CommandText = "spCountCandidatesTechnologies";

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlComm.CommandText, sqlConn);
                sqlDataAdapter.Fill(datatableCountCandidatesInTechnology);
                sqlConn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return datatableCountCandidatesInTechnology;
        }

        public DataTable GetCountCandidatesInLeads()
        {
            DataTable datatableCountCandidatesInLeads = new DataTable();

            try
            {
                SqlConnection sqlConn = new SqlConnection(_connectionString);
                sqlConn.Open();

                //SqlCommand sqlComm = new SqlCommand("spCountCandidatesLeads", sqlConn);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(@"exec spCountCandidatesLeads", sqlConn);
                sqlDataAdapter.Fill(datatableCountCandidatesInLeads);
                sqlConn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return datatableCountCandidatesInLeads;
        }

        public DataTable GetTechnologyHavingCandidates()
        {
            DataTable datatableTechnologyHavingCandidates = new DataTable();

            try
            {
                SqlConnection sqlConn = new SqlConnection(_connectionString);
                sqlConn.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(@"exec spCountCandidatesTechnologiesMinThree;", sqlConn);
                sqlDataAdapter.Fill(datatableTechnologyHavingCandidates);
                sqlConn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return datatableTechnologyHavingCandidates;
        }

        public DataTable GetLeadWithMaxCandidates()
        {
            DataTable datatableLeadWithMaxCandidates = new DataTable();

            try
            {
                SqlConnection sqlConn = new SqlConnection(_connectionString);
                sqlConn.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(@"exec spGetLeadWithMaxCandidates;", sqlConn);

                sqlDataAdapter.Fill(datatableLeadWithMaxCandidates);
                sqlConn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return datatableLeadWithMaxCandidates;
        }
    }
}