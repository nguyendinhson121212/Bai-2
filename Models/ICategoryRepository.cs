namespace Bai_2.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetCategories();
    }
}
