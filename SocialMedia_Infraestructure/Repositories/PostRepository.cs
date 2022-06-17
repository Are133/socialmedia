using Microsoft.EntityFrameworkCore;
using SocialMedia_Core.Entities;
using SocialMedia_Core.Interfaces;
using SocialMedia_Infraestructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia_Infraestructure.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly SocialMediaContext _mediaContext;
        public PostRepository(SocialMediaContext mediaContext)
        {
            _mediaContext = mediaContext;
                
        }
        public async Task<IEnumerable<Publicacion>> GetPosts()
        {
            var posts = await _mediaContext.Publicacion.ToListAsync();
            await Task.Delay(10);
            return posts;
        }

    }
}
