using SampleLoadBalancing.Models;

namespace SampleLoadBalancing.Services;

public interface IUserService
{
    Task<IEnumerable<User>> GetAllAsync();
    Task<User?> GetByIdAsync(long id);
    Task<User> CreateAsync(User user);
    Task<User?> UpdateAsync(long id, User user);
    Task<bool> DeleteAsync(long id);
}