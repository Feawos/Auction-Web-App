using AuctionWebApplication.Models;

namespace AuctionWebApplication.Data.Services
{
    public interface ICommentsService
    {
        Task Add(Comment comment);
    }
}