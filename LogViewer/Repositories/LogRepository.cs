using System.Net;
using LogViewer.Models;

namespace LogViewer.Repositories;

public class LogRepository : ILogRepository
{
    public List<Log> Logs { get; set; }
    
    public List<Log> InitializeData()
    {
        Logs = new List<Log>()
        {
            new Log()
            {
                Id = 1, Host = "80.214.78.250",
                TimeStamp = new DateTime(2020, 02, 20, 07, 46, 25), Message = "GET /api/user/invitation HTTP/1.1"
            },
            new Log()
            {
                Id = 2, Host = "80.214.78.250",
                TimeStamp = new DateTime(2020, 02, 20, 07, 46, 56), Message = "GET /api/user/invitation HTTP/1.1"
            },
            new Log()
            {
                Id = 3, Host = "80.214.78.250",
                TimeStamp = new DateTime(2020, 02, 20, 07, 47, 05), Message = "GET /api/user/profile/181 HTTP/1.1"
            },

        };
        return Logs;
    }

    public List<Log> GetAll()
    {
        return Logs;
    }

    public List<Log> GetAllFiltered(Filters filters)
    {
        List<Log> filteredList = Logs;
        if (filters.StartDate != null && filters.EndDate != null)
        {
            filteredList = filteredList.Where(x => x.TimeStamp >= filters.StartDate && x.TimeStamp <= filters.EndDate).ToList();
        }
        if (filters.Host != null)
        {
            filteredList = filteredList.Where(x => x.Host == filters.Host).ToList();
        }
        if (filters.Message != null)
        {
            filteredList = filteredList.Where(x => x.Message.Contains(filters.Message)).ToList();
        }
        return filteredList;
    }
}