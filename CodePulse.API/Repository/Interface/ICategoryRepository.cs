using CodePulse.API.Models.Domain;

namespace CodePulse.API.Repository.Interface
{
    public interface ICategoryRepository
    {
        Task<Category> CreateAsync(Category category);
        Task<IEnumerable<Category>> GetAllAsync();

        Task<Category?> GetById(Guid id);
    }
}
