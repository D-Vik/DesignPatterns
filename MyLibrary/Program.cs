﻿using MyLibrary.Builder;
using System;

namespace MyLibrary
{
  class Program
  {
    static void Main(string[] args)
    {
      Report report;

      ReportDirector director = new ReportDirector();

      PDFReport pdf = new PDFReport();
      report = director.MakeReport(pdf);
      report.DisplayReport();

      ExcelReport excel = new ExcelReport();
      report = director.MakeReport(excel);
      report.DisplayReport();
    }
  }
}
