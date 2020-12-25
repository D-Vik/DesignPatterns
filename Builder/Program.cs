namespace Builder
{
  class Program
  {
    static void Main(string[] args)
    {
      Report report;

      ReportDirector director = new ReportDirector();

      PDF pdf = new PDF();
      report = director.MakeReport(pdf);
      report.DisplayReport();

      Excel excel = new Excel();
      report = director.MakeReport(excel);
      report.DisplayReport();
    }
  }
}
