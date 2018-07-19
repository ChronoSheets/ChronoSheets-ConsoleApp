using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace JobCodeLister
{
    class Program
    {
        static void Main(string[] args)
        {
            var xChronosheetsAuth_example = "";
            var apiLoginInstance = new UserProfileApi();

            try
            {
                var loginRequest = new CSDoLoginRequest("Nock1997", "Password02@");
                var loginResult = apiLoginInstance.UserProfileDoLogin(loginRequest);

                if(loginResult.Status == CSApiResponseDoLoginResponse.StatusEnum.Succeeded)
                {
                    xChronosheetsAuth_example = loginResult.Data.CSAuthToken;
                }
                else
                {
                    Console.WriteLine("Error logging in: " + loginResult.Message);
                    Console.ReadKey();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception when calling UserProfileApi.UserProfileDoLogin: " + e.Message);
                Console.ReadKey();
            }
            if (!string.IsNullOrWhiteSpace(xChronosheetsAuth_example)) {
                var apiInstance = new AggregateJobTasksApi();
                var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

                try
                {
                    // Get jobs and tasks information, aggregated.    Requires the 'SubmitTimesheets' or 'ManageJobsAndTask' permissions.
                    CSApiResponseListAggregateJobCode result = apiInstance.AggregateJobTasksGetAggregateJobTasks(xChronosheetsAuth);
                    
                    if(result.Status == CSApiResponseListAggregateJobCode.StatusEnum.Succeeded)
                    {
                        foreach(var job in result.Data)
                        {
                            Console.WriteLine(string.Format("Job: {0}, Client: {1}, Project: {2}", job.Code, job._Client, job.Project));

                            foreach(var task in job.AvailableTasks)
                            {
                                Console.WriteLine(string.Format("    Task: {0}", task.Label));
                            }
                            Console.WriteLine("");
                        }
                        Console.ReadKey();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception when calling AggregateJobTasksApi.AggregateJobTasksGetAggregateJobTasks: " + e.Message);
                    Console.ReadKey();
                }
            }
        }
    }
}
