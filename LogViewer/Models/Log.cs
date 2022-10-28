using System.Net;

namespace LogViewer.Models;

public class Log
{
    public int Id { get; set; }
    public DateTime TimeStamp { get; set; }
    public string Host { get; set; }
    public string Message { get; set; }

}