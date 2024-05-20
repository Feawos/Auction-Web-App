using AuctionWebApplication.Models;

namespace AuctionWebApplication.Data.Services
{
    public interface IBidsService
    {
        Task Add(Bid bid);
        IQueryable<Bid> GetAll();
    }
}