namespace Builder
{
  public class ReportDirector
  {
    public Report MakeReport(ReportBuilder builder)
    {
      builder.CreateNewReport();
      builder.SetReportType();
      builder.SetReportHeader();
      builder.SetReportContent();
      builder.SetReportFooter();

      return builder.GetReport();
    }
  }
}
