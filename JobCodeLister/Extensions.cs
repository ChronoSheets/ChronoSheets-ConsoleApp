using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace JobCodeLister
{
    public static class Extensions
    {
        public static string PrintMyJobCodeDetails(this CSAggregateJobCode job)
        {
            return string.Format("Job: {0}, Client: {1}, Project: {2}", job.Code, job._Client, job.Project);
        }
        public static string PrintMyTaskDetails(this CSAggregateJobTask task)
        {
            return string.Format("{0}Task: {1}", "\t", task.Label);
        }
    }
}
