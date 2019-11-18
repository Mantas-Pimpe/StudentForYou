using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using StudentForYou.WebApp.Models;

namespace StudentForYou.WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : DataBaseController
    {
        readonly QuestionsDB db = new QuestionsDB();
        private readonly List<Question> list = db.GetQuestions();
        // GET: api/Question
        [HttpGet]
        public List<Question> Get()
        {
            //var question = db.GetQuestions();
            //HttpResponseMessage response = Request.(HttpStatusCode.OK, question);
            return list;

        }

        // GET: api/Question/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Question
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        // PUT: api/Question/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}
