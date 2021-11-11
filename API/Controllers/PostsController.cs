using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API.Models;
using API.Models.Interfaces;
using Microsoft.AspNetCore.Cors;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        // GET: api/Posts
        [EnableCors("AnotherPolicy")]
        [HttpGet]
        public List<Post> Get()
        {
            IGetAllPosts readObject = new ReadPostData();
            return readObject.GetAllPosts();
        }

        // GET: api/Posts/5
        [EnableCors("AnotherPolicy")]
        [HttpGet("{id}", Name = "Get")]
        public Post Get(int id)
        {
            IGetPost readObject = new ReadPostData();
            return readObject.GetPost(id);
        }

        // POST: api/Posts
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Posts/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Posts/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
