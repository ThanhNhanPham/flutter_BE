using FoodOdering_BE.Model;

namespace FoodOdering_BE.Repository
{
    public interface IQRCodeRepository
    {
        Task<QRCode> GetQRCodeByOrderIdAsync(int orderId);
        Task AddQRCodeAsync(QRCode qrCode);
        Task<QRCode> GetQRCodeByIdAsync(int qrCodeId);
    }
}
