﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Security.Cryptography;

namespace API.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(string id)
        {
            return id;
        }

        // POST api/values
        public string Post([FromBody]string value)
        {
            return "hola";
        }

        // PUT api/values/5
        public string Put([FromBody]string value)
        {
            return "chao";
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}