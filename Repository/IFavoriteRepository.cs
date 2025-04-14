using FoodOdering_BE.Model;

namespace FoodOdering_BE.Repository
{
    public interface IFavoriteRepository
    {
        Task<IEnumerable<Favorite>> GetAllFavoritesByUserIdAsync(string userId);
        Task AddToFavoriteAsync(Favorite favorite);
        Task RemoveFromFavoriteAsync(int favoriteId);
    }

}
