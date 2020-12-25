namespace Builder
{
  class Excel : ReportBuilder
  {
    public override void SetReportContent()
    {
      reportObject.ReportContent = "Excel content section"; 
    }

    public override void SetReportFooter()
    {
      reportObject.ReportFooter = "Excel footer";
    }

    public override void SetReportHeader()
    {
      reportObject.ReportHeader = "Excel header";
    }

    public override void SetReportType()
    {
      reportObject.ReportType = "Excel";
    }
  }
}
