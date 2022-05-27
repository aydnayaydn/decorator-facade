//Concrete Implementation
class PlainReport : IReport
{
    private string _content;
    public PlainReport(string content) => _content = content;
    public string GetContentText() => _content;
}
