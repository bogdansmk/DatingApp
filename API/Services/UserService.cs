using System.Threading.Tasks;
using API.Helpers;
using API.Interfaces;

namespace API.Services
{
    public class UserService : IUserService
    {
        private const int MinAge = 18;
        private const int MaxAge = 99;

        public GetMembersResult GetMembers(UserParams userParams)
        {
            GetMembersResult result = new GetMembersResult { IsValid = true };

            if (userParams.MinAge < MinAge || userParams.MaxAge > MaxAge ||
                userParams.MinAge > MaxAge || userParams.MaxAge < MinAge)
            {
                result.IsValid = false;
                result.Message = userParams.MinAge < MinAge
                    ? $"The minimum age of users cannot be less than {MinAge}."
                    : $"The maximum age of users cannot be greater than {MaxAge}.";

                return result;
            }

            return result;
        }
    }
}