using SocialMedia_Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SocialMedia_Core.Interfaces
{
    public interface IPostRepository
    {
        Task<IEnumerable<Publicacion>> GetPosts();
    }
}
