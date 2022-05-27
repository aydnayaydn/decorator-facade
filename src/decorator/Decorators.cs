//Base Decorator
class ReportDecorator : IReport
{
    private IReport _report;
    public ReportDecorator(IReport report) => _report = report;
    public virtual string GetContentText() => _report.GetContentText();
}

enum ReportType{
    Line,
    UpperCase,
    Signed
}

//Concrete Decorators
class LineReportDecorator : ReportDecorator
{
    public LineReportDecorator(IReport report) : base(report) {}
    override public string GetContentText() =>  "-" + base.GetContentText().Replace("\n", "\n-");
}

class UpperCaseReportDecorator : ReportDecorator
{
    public UpperCaseReportDecorator(IReport report) : base(report) {}
    override public string GetContentText() =>  base.GetContentText().ToUpper();
}

class SignedReportDecorator : ReportDecorator
{
    public SignedReportDecorator(IReport report) : base(report) {}
    override public string GetContentText() =>  base.GetContentText() + "\n \t Sign: Author";
}