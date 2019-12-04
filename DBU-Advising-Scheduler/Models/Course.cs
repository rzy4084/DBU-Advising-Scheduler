using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBU_Advising_Scheduler.Models
{
    public class Course
    {
        public string ReportingTerm { get; set; }
        public string Term { get; set; }
        public string CourseName { get; set; }
        public string CourseNumber { get; set; }
        public string Section { get; set; }
        public string Title { get; set; }
        public string DivisionDesc { get; set; }
        public string Department { get; set; }
        public string DepartmentDesc { get; set; }
        public string CurrentStatus { get; set; }
        public string Location { get; set; }
        public string Building { get; set; }
        public string Room { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Days { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string SectionCapacity { get; set; }
        public string FacultyFName { get; set; }
        public string FacultyLName { get; set; }
        public string Notes { get; set; }
        public string Year { get; set; }
        public string StartDT { get; set; }
        public string EndDT { get; set; }
    }
}