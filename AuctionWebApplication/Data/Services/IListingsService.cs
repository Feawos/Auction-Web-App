using AuctionWebApplication.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AuctionWebApplication.Data.Services
{
    public interface IListingsService
    {
        IQueryable<Listing> GetAll();
        Task Add(Listing listing);
        Task Update(Listing listing);
        Task Delete(Listing listing);
        Task<Listing> GetById(int? id);
        Task <bool> SaveChanges();
        Task<List<ApplicationUser>> GetAllUsersAsync();
    }
}