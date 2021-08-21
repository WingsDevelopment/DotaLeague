using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationServices.ApplicationDTOs
{
    public class ReportCreateParamsDTO
    {
        public string UserEmail { get; set; }
        public string Content { get; set; }

        public ReportCreateParamsDTO(string userEmail, string content)
        {
            UserEmail = userEmail;
            Content = content;
        }
    }
}
