using DBU_Advising_Scheduler.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DBU_Advising_Scheduler.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        public ActionResult Courses()
        {
            String connectionString = "server=172.20.63.111;user id=pi;database=dbuas;persistsecurityinfo=True";

            String sql = "SELECT * FROM dbu_course_listing";
            SqlCommand cmd = new SqlCommand(sql);
            
            var model = new List<Course>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    var course = new Course();
                    course.ReportingTerm = rdr["Reporting Term"].ToString();
                    course.Term = rdr["Term"].ToString();
                    course.CourseName = rdr["CourseName"].ToString();
                    course.CourseNumber = rdr["CourseNumber"].ToString();
                    course.Section = rdr["Section"].ToString();
                    course.Title = rdr["Title"].ToString();
                    course.DivisionDesc = rdr["DivisionDesc"].ToString();
                    course.Department = rdr["Department"].ToString();
                    course.DepartmentDesc = rdr["DepartmentDesc"].ToString();
                    course.CurrentStatus = rdr["CurrentStatus"].ToString();
                    course.Location = rdr["Location"].ToString();
                    course.Building = rdr["Building"].ToString();
                    course.Room = rdr["Room"].ToString();
                    course.StartDate = rdr["StartDate"].ToString();
                    course.EndDate = rdr["EndDate"].ToString();
                    course.Days = rdr["Days"].ToString();
                    course.StartTime = rdr["StartTime"].ToString();
                    course.EndTime = rdr["EndTime"].ToString();
                    course.SectionCapacity = rdr["SectionCapacity"].ToString();
                    course.FacultyFName = rdr["FacultyFName"].ToString();
                    course.FacultyLName = rdr["FacultyLName"].ToString();
                    course.Notes = rdr["Notes"].ToString();
                    course.Year = rdr["Year"].ToString();
                    course.StartDT = rdr["StartDT"].ToString();
                    course.EndDT = rdr["EndDT"].ToString();
                    model.Add(course);
                }

            }

            return View(model);
        }
    }
}