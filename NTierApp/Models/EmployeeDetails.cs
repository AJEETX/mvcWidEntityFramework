using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NTierApp.Models
{
    public class EmployeeDetails
    {
        public int EmployeeDetailsId { get; set; }
        public string EmpName { get; set; }
        public string EmpAddress { get; set; }
        public string EmpEmailId { get; set; }
    }
}