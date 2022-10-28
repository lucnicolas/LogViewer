using LogViewer.Models;

namespace LogViewer.Repositories;

public interface ILogRepository
{
    List<Log> Logs { get; set; }
    List<Log> InitializeData();
    List<Log> GetAll();
    List<Log> GetAllFilteredAndSorted(Filters filters, string sortOrder);
}