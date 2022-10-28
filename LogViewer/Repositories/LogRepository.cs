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
                TimeStamp = new DateTime(2022, 02, 20, 07, 46, 25), Content = "GET /api/user/invitation HTTP/1.1"
            },
            new Log()
            {
                Id = 2, Host = "80.214.78.250",
                TimeStamp = new DateTime(2020, 02, 20, 07, 46, 56), Content = "GET /api/user/invitation HTTP/1.1"
            },
            new Log()
            {
                Id = 3, Host = "80.214.78.250",
                TimeStamp = new DateTime(2020, 02, 20, 07, 47, 05), Content = "GET /api/user/profile/181 HTTP/1.1"
            },
            new Log()
            {
                Id = 4, Host = "83.193.99.47",
                TimeStamp = new DateTime(2020, 02, 20, 09, 39, 28), Content = "GET /api/user/invitation HTTP/1.1"
            },
            new Log()
            {
                Id = 5, Host = "83.193.99.47",
                TimeStamp = new DateTime(2020, 02, 20, 09, 39, 28), Content = "GET /api/user/invitation HTTP/1.1"
            },
            new Log()
            {
                Id = 6, Host = "83.193.99.47",
                TimeStamp = new DateTime(2020, 02, 20, 09, 39, 28), Content = "GET /api/user/invitation HTTP/1.1"
            },
            new Log()
            {
                Id = 7, Host = "83.193.99.47",
                TimeStamp = new DateTime(2020, 02, 20, 09, 39, 28), Content = "GET /api/user/invitation HTTP/1.1"
            },
            new Log()
            {
                Id = 8, Host = "83.193.99.47",
                TimeStamp = new DateTime(2020, 02, 20, 09, 39, 28), Content = "GET /api/user/invitation HTTP/1.1"
            },
            new Log()
            {
                Id = 9, Host = "83.193.99.47",
                TimeStamp = new DateTime(2020, 02, 20, 09, 39, 28), Content = "GET /api/user/invitation HTTP/1.1"
            },
            new Log()
            {
                Id = 10, Host = "83.193.99.47",
                TimeStamp = new DateTime(2020, 02, 20, 09, 39, 28), Content = "GET /api/user/invitation HTTP/1.1"
            },
            new Log()
            {
                Id = 11, Host = "83.193.99.47",
                TimeStamp = new DateTime(2020, 02, 20, 09, 39, 28), Content = "GET /api/user/invitation HTTP/1.1"
            },
            new Log()
            {
                Id = 12, Host = "83.193.99.47",
                TimeStamp = new DateTime(2022, 10, 28, 12, 10, 28), Content = "GET /api/user/invitation HTTP/1.1"
            },
            new Log()
            {
                Id = 13, Host = "83.193.99.47",
                TimeStamp = new DateTime(2022, 10, 28, 13, 33, 10), Content = "GET /api/user/invitation HTTP/1.1"
            },
            new Log()
            {
                Id = 14, Host = "83.193.99.47",
                TimeStamp = new DateTime(2022, 10, 28, 15, 58, 28), Content = "GET /api/user/invitation HTTP/1.1"
            },
            new Log()
            {
                Id = 15, Host = "83.193.99.47",
                TimeStamp = new DateTime(2022, 10, 28, 15, 59, 28), Content = "GET /api/user/invitation HTTP/1.1"
            },

        };
        return Logs;
    }

    public List<Log> GetAll()
    {
        return Logs;
    }

    public List<Log> GetAllFilteredAndSorted(Filters filters, string sortOrder)
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
        if (filters.Content != null)
        {
            filteredList = filteredList.Where(x => x.Content.Contains(filters.Content)).ToList();
        }

        switch (sortOrder)
        {
            case "date_asc":
                filteredList = filteredList.OrderBy(x => x.TimeStamp).ToList();
                break;
            case "date_desc":
                filteredList = filteredList.OrderByDescending(x => x.TimeStamp).ToList();
                break;
        }
        
        return filteredList;
    }
}