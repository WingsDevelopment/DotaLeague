using DotaLeague.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationServices.ApplicationDTOs
{
    public class ReportDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Content { get; set; }

        public ReportDTO(Report report)
        {
            Id = report.Id;
            UserId = report.UserId;
            Content = report.Content;
        }
    }

    public static class ReportDTOExtension
    {
        public static ICollection<ReportDTO> ToReportDTOs(this ICollection<Report> reports)
        {
            return reports.Select(a => new ReportDTO(a)).ToList();
        }
    }
}
