using Microsoft.EntityFrameworkCore;
using SampleLoadBalancing.Data;
using SampleLoadBalancing.Models;

namespace SampleLoadBalancing.Services;

public class UserService(ApplicationDbContext context) : IUserService
{
    public async Task<IEnumerable<User>> GetAllAsync()
    {
        return await context.Users.AsNoTracking().ToListAsync();
    }

    public async Task<User?> GetByIdAsync(long id)
    {
        return await context.Users.AsNoTracking().FirstOrDefaultAsync(u => u.Id == id);
    }

    public async Task<User> CreateAsync(User user)
    {
        context.Users.Add(user);
        await context.SaveChangesAsync();
        return user;
    }

    public async Task<User?> UpdateAsync(long id, User updatedUser)
    {
        var existingUser = await context.Users.FindAsync(id);
        if (existingUser == null)
            return null;

        existingUser.Name = updatedUser.Name;
        await context.SaveChangesAsync();
        return existingUser;
    }

    public async Task<bool> DeleteAsync(long id)
    {
        var user = await context.Users.FindAsync(id);
        if (user == null)
            return false;

        context.Users.Remove(user);
        await context.SaveChangesAsync();
        return true;
    }
}