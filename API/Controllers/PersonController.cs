using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestApi1.Models;

namespace TestApi1.Controllers
{
    [System.Web.Http.Cors.EnableCors(origins: "http://localhost:8000", headers: "*", methods: "*")]
    public class PersonController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Person> Get()
        {
            return new List<Person> { new Person("John", "Doe", "Zookeeper"), new Person("Jane", "Doe", "Surveyor") };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        //PUT api/<controller>/5
        //public void Put(int id, [FromBody]Person value)
        //{
        //    Console.WriteLine(value.FirstName + " " + value.LastName + ", " + value.JobTitle);
        //}

        //PUT api/<controller>/5
        public void Put(int id, string firstname, string lastname, string jobtitle)
        {
            System.Diagnostics.Trace.WriteLine("First Name: " + firstname + ", LastName: " + lastname + ", Job Title: " + jobtitle);
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}