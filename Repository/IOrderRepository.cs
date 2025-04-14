using FoodOdering_BE.Model;

namespace FoodOdering_BE.Repository
{
    public interface IOrderRepository
    {
        Task<IEnumerable<Order>> GetAllOrdersAsync();
        Task<Order> GetOrderByIdAsync(int id);
        Task<IEnumerable<Order>> GetOrdersByUserIdAsync(string userId);
        Task AddOrderAsync(Order order);
        Task UpdateOrderStatusAsync(int orderId, string status);
        Task DeleteOrderAsync(int id);
    }

}
