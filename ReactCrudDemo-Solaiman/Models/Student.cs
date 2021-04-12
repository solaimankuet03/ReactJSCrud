using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReactCrudDemo_Solaiman.Models
{
    public class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Rollno { get; set; }
        public string Class { get; set; }
        public string Address { get; set; }
    }

    public class Response
    {
        public Response()
        {
            Data = new List<Student>();
        }

        public string Status { get; set; }
        public string Message { get; set; }
        public List<Student> Data { get; set; }
    }
}
