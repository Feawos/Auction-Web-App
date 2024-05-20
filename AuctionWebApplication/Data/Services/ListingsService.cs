using AuctionWebApplication.Models;
using Microsoft.EntityFrameworkCore;
using AuctionWebApplication.Data;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Collections.Immutable;
using Microsoft.Identity.Client;

namespace AuctionWebApplication.Data.Services
{
    public class ListingsService : IListingsService
    {
        private readonly ApplicationDbContext _context;

        public ListingsService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Add(Listing listing)
        {
            _context.Listings.Add(listing);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Listing listing)
        {
            var existingListing = await _context.Listings.FindAsync(listing.Id);
            if (existingListing != null)
            {
               // existingListing.Title = listing.Title;
               // existingListing.Description = listing.Description;
               // existingListing.Price = listing.Price;
               // existingListing.ImagePath = listing.ImagePath;
               // existingListing.IsSold = listing.IsSold;
               // existingListing.IdentityUserId = listing.IdentityUserId;
               // _context.Entry(existingListing).State = EntityState.Modified;
               // _context.Listings.Update(listing);
                _context.Update(listing);
            }
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Listing listing)
        {
            await _context.Listings.FindAsync(listing.Id);
            if (listing != null)
            {
                _context.Listings.Remove(listing);
            } 
            await _context.SaveChangesAsync();
        }

        public IQueryable<Listing> GetAll()
        {
            var applicationDbContext = _context.Listings.Include(l => l.User);
            return applicationDbContext;
        }

        public async Task<Listing> GetById(int? id)
        {
            var listing = await _context.Listings
                .Include(l => l.User)
                .Include(l => l.Comments)
                .Include(l => l.Bids)
                .ThenInclude(l => l.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            return listing;
        }

        public async Task<bool>  SaveChanges()
        {
            
            int result = await _context.SaveChangesAsync();
            return result > 0; 
        }

        public async Task<List<ApplicationUser>> GetAllUsersAsync()
        {
            return await _context.Users.ToListAsync();
        }

    }
}
