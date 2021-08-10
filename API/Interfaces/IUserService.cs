using System.Threading.Tasks;
using API.DTOs;
using API.Helpers;

namespace API.Interfaces
{
    public interface IUserService
    {
        GetMembersResult GetMembers(UserParams userParams);
    }
}