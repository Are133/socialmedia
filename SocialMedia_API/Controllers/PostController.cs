using Microsoft.AspNetCore.Mvc;
using SocialMedia_Core.Interfaces;
using System.Threading.Tasks;

namespace SocialMedia_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostRepository _postRepository;
        public PostController(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetPosts()
        {
            var pots = await _postRepository.GetPosts();
            return Ok(pots);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPost(int id)
        {
            var pots = await _postRepository.GetPost(id);
            return Ok(pots);
        }
    }
}
