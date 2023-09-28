using API.DTO;
using API.Entities;

namespace API.Interfaces
{
    public interface IUserRepository
    {

        void Update(AppUser user);

        Task<bool> SaveAllAsync();

        Task<IEnumerable<AppUser>> GetUsersAsync();

        Task<IEnumerable<MemberDto>> GetMembersAsync();

        Task<AppUser> GetByIdAsync(int id);
        Task<AppUser> GetUserByUserName(string username);

        Task<MemberDto> GetMemberByUserName(string username);
    }
}
