using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Models
{
    public class CollectProject
    {
        public string JobCode { get; set; }
        public string JobCodeName { get; set; }
        public string Revenue { get; set; }
        public string NumSR { get; set; }
        public string NumPOT { get; set; }
        public DateTime PlanStartDate { get; set; }
        public DateTime PlanEndDate { get; set; }
        public DateTime ActualStartDate { get; set; }
        public DateTime ActualEndDate { get; set; }
        public string ProjectName { get; set; }
        public string AttachFile { get; set; }
        public string Type { get; set; }
        public string ProjectManager { get; set; }
        public string ProjectStatus { get; set; }
        public string BusinessTeam { get; set; }
        public int BusinessUnit { get; set; }
        public string BusinessAnalyst { get; set; }
    }
}
