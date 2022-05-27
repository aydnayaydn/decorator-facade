static class DecoratorApp
{
    public static void Run(){
        Console.WriteLine("-----Decorator Pattern-----");

        var content = "Lorem Ipsum is simply dummy text of the printing and" 
                + "\ntypesetting industry. Lorem Ipsum has been the industry's "
                + "\nstandard dummy text ever since the 1500s.";
                
        var type1 = new ReportType[] {ReportType.Line };
        var type2 = new ReportType[] {ReportType.UpperCase} ;
        var type3 = new ReportType[] {ReportType.Line, ReportType.Signed} ;

        PlainReport report = new PlainReport(content);
        // Console.WriteLine(report.GetContentText());

        // var lineReport = new LineReportDecorator(report);
        // Console.WriteLine(lineReport.GetContentText());

        // var upperCaseReport = new UpperCaseReportDecorator(report);
        // Console.WriteLine(upperCaseReport.GetContentText());

        ShowReport(report, type1);
        ShowReport(report, type2);
        ShowReport(report, type3);
    }
    static void ShowReport(PlainReport report, ReportType[] type)
    {
        ReportDecorator decorator = new ReportDecorator(report);

        if (type.Contains(ReportType.Line))
            decorator = new LineReportDecorator(decorator);
        if (type.Contains(ReportType.UpperCase))
            decorator = new UpperCaseReportDecorator(decorator);
        if (type.Contains(ReportType.Signed))
            decorator = new SignedReportDecorator(decorator);

        Console.WriteLine(decorator.GetContentText() + "\n");
    }
}