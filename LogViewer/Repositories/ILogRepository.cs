using LogViewer.Models;

namespace LogViewer.Repositories;

public interface ILogRepository
{
    List<Log> LogList { get; set; }
    List<Log> InitializeData();
    List<Log> GetAll();
    List<Log> GetAllFiltered(Filters filters);
}