using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
//using NITGEN.SDK.NBioBSP;



namespace SimpleRestServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            //var m_NBioAPI = new NBioAPI();
            return new string[] { "Ola Mundo!!!!!!!" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            iniciar();
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


        private void iniciar()
        {           


            System.Diagnostics.Debug.WriteLine("asdasdasdasdas");
        }




    }
}
