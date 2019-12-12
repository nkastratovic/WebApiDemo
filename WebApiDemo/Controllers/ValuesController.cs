using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiDemo.Controllers
{
    public class ValuesController : ApiController
    {
        List<string> apiList = new List<string>()
        {
            "Value1", "Value2", "Value3"
        };

        public List<string> Get()
        {
            return apiList;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return apiList[id].ToString();
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
            apiList.Add(value);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
            apiList[id] = value;
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            apiList.RemoveAt(id);
        }
    }
}
