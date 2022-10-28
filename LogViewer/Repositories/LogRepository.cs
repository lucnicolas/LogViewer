using System.Net;
using LogViewer.Models;

namespace LogViewer.Repositories;

public class LogRepository : ILogRepository
{
    public List<Log> LogList { get; set; }
    
    public List<Log> InitializeData()
    {
        LogList = new List<Log>()
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
        return LogList;
    }

    public List<Log> GetAll()
    {
        return LogList;
    }
}