namespace LogViewer.Models;

public class Filters
{
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }    
    public string Host { get; set; }
    public string Content { get; set; }
}