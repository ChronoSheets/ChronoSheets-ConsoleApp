using System;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace JobCodeLister
{
    class Program
    {
        static void Main(string[] args)
        {
            var xChronosheetsAuth_example = "";

            while (string.IsNullOrWhiteSpace(xChronosheetsAuth_example))
            {
                Console.Clear();
                Console.WriteLine("Enter your username");
                var username = Console.ReadLine();

                Console.WriteLine("Enter your password");
                var password = Console.ReadLine();

                var doLoginResult = DoLogin(username, password);

                if (doLoginResult.Item1)
                {
                    break;
                }
                else
                {
                    xChronosheetsAuth_example = doLoginResult.Item2;
                }
            }


            if (!string.IsNullOrWhiteSpace(xChronosheetsAuth_example)) {
                Console.Clear();

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
                            Console.WriteLine(job.PrintMyJobCodeDetails());

                            foreach(var task in job.AvailableTasks)
                            {
                                Console.WriteLine(task.PrintMyTaskDetails());
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
        static Tuple<bool, string> DoLogin(string userName, string password)
        {
            var xChronosheetsAuth_example = "";
            var apiLoginInstance = new UserProfileApi();
            var wantsExit = false;

            try
            {
                var loginRequest = new CSDoLoginRequest(userName, password);
                var loginResult = apiLoginInstance.UserProfileDoLogin(loginRequest);

                if (loginResult.Status == CSApiResponseDoLoginResponse.StatusEnum.Succeeded)
                {
                    xChronosheetsAuth_example = loginResult.Data.CSAuthToken;
                }
                else
                {
                    Console.WriteLine("Error logging in: " + loginResult.Message);
                    Console.WriteLine("Please try again, or press 'Q' to quit the app. Press enter to try again.");
                    var input = Console.ReadLine().Trim().ToUpper();

                    if(input == "Q")
                    {
                        wantsExit = true;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception when calling UserProfileApi.UserProfileDoLogin: " + e.Message);
                wantsExit = true;
                Console.ReadKey();
            }
            return new Tuple<bool, string>(wantsExit, xChronosheetsAuth_example);
        }
    }
}
