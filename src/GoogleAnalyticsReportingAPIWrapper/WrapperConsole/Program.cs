﻿using System;
using Google.Apis.AnalyticsReporting.v4.Data;
using Report = GoogleAnalyticsReportingAPIWrapper.Report;

namespace WrapperConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Report report = new Report();

            GetReportsResponse response = report.Get(DateTime.UtcNow.AddDays(-1).ToString("yyyy-MM-dd"), DateTime.UtcNow.ToString("yyyy-MM-dd"), new[] { "ga:eventValue" }, new[] { "ga:eventCategory, ga:eventAction, ga:eventLabel" }, "[yourViewId]", "[json file generated by Google API console]", new[] { "https://www.googleapis.com/auth/analytics.readonly" }, "Wrapper app");
        }
    }
}
