using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApiMiddleware.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}





//HttpContext httpContext = HttpContext.Current;

//string authHeader = this.httpContext.Request.Headers["Authorization"];

//if (authHeader != null && authHeader.StartsWith("Basic")) {
//    string encodedUsernamePassword = authHeader.Substring("Basic ".Length).Trim();
//Encoding encoding = Encoding.GetEncoding("iso-8859-1");
//string usernamePassword = encoding.GetString(Convert.FromBase64String(encodedUsernamePassword));

//int seperatorIndex = usernamePassword.IndexOf(':');

//var username = usernamePassword.Substring(0, seperatorIndex);
//var password = usernamePassword.Substring(seperatorIndex + 1);
//} else {
//    //Handle what happens if that isn't the case
//    throw new Exception("The authorization header is either empty or isn't Basic.");
//}
