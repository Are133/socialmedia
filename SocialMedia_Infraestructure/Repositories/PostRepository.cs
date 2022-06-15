using SocialMedia_Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SocialMedia_Infraestructure.Repositories
{
    public class PostRepository
    {
        public IEnumerable<Post> GetPosts()
        {
            var posts = Enumerable.Range(1, 10).Select(p => new Post
            {
                PostId = p,
                Description = $"Welcome To World, No Live {p}",
                UserId = p,
                Date = DateTime.Now,
                UrlImage = $"https://www.miapinet.com/{p}"
            });
            return posts;
        }

    }
}
