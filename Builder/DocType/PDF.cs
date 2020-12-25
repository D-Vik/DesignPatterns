namespace Builder
{
  public class PDF : ReportBuilder
  {
    public override void SetReportContent()
    {
      reportObject.ReportContent = "PDF content section";
    }

    public override void SetReportFooter()
    {
      reportObject.ReportFooter = "PDF footer";
    }

    public override void SetReportHeader()
    {
      reportObject.ReportHeader = "PDF header";
    }

    public override void SetReportType()
    {
      reportObject.ReportType = "PDF";
    }
  }
}
