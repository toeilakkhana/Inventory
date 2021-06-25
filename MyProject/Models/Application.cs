using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace MyProject.Models
{
    public class Application
    {
        public int SupportId { get; set; }
        public string AppId { get; set; }
        public string AppName { get; set; }
        public string AppObj { get; set; }
        public string AppUrl { get; set; }
        public string Company { get; set; }
        public string DocPath { get; set; }
        public string FucDes { get; set; }
        public string Remark { get; set; }
        public string Source_Path { get; set; }
        public string Port { get; set; }
        
        public string OcioName { get; set; }
        public string ProjectManager { get; set; }
        public string DatabaseName { get; set; }
        public string Bu { get; set; }
        
        public string AppStatusName { get; set; }
        public string AppStatus { get; set; }
        public string Department { get; set; }
        public string OsSystem { get; set; }
        public string Smtp { get; set; }
        public string ServerType { get; set; }
        public string SoftwareVer { get; set; }
        //public bool Criticality { get; set; }




    }
}