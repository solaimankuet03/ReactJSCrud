using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ReactCrudDemo_Solaiman.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReactCrudDemo_Solaiman.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [Route("AddorUpdatestudent")]
        [HttpPost]
        public object AddorUpdatestudent(Student st)
        {
            List<Student> students = new List<Student>();
            try
            {
                students = ReturnStaticList();
                students.Add(st);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            return new Response
            {
                
                Status = "Error",
                Message = "Data not insert",
                Data = students                
            };
        }

        [Route("Studentdetails")]
        [HttpGet]
        public object Studentdetails()
        {
            var a = ReturnStaticList();
            return a;
        }

        [Route("Deletestudent")]
        [HttpDelete]
        public object Deletestudent(string id)
        {
            var obj = ReturnStaticList().Where(x => x.Rollno == id).ToList().FirstOrDefault();
            ReturnStaticList().Remove(obj);
            return new Response
            {
                Status = "Delete",
                Message = "Delete Successfuly"
            };
        }

        private List<Student> ReturnStaticList()
        {
            List<Student> students = new List<Student>();

            Student student1 = new Student
            {
                Name = "Solaiman Ali",
                Rollno = "00001",
                Address = "Dhaka",
                Class = "CSE"
            };

            students.Add(student1);

            Student student2 = new Student
            {
                Name = "Solaiman Ali",
                Rollno = "00001",
                Address = "Dhaka",
                Class = "CSE"
            };

            students.Add(student2);

            Student student3 = new Student
            {
                Name = "Solaiman Ali",
                Rollno = "00001",
                Address = "Dhaka",
                Class = "CSE"
            };

            students.Add(student3);

            Student student4 = new Student
            {
                Name = "Solaiman Ali",
                Rollno = "00001",
                Address = "Dhaka",
                Class = "CSE"
            };

            students.Add(student4);

            Student student5 = new Student
            {
                Name = "Solaiman Ali",
                Rollno = "00001",
                Address = "Dhaka",
                Class = "CSE"
            };

            students.Add(student5);

            return students;
        }

        [Route("StudentdetailById")]
        [HttpGet]
        public object StudentdetailById(string id)
        {
            var obj = ReturnStaticList().Where(x => x.Rollno == id).ToList().FirstOrDefault();
            return obj;
        }

    }
}
