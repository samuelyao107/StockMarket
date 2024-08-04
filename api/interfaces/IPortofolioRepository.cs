using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;

namespace api.interfaces
{
    public interface IPortofolioRepository
    {
    
        Task<List<Stock>> GetUserPortofolio(AppUser user);
        Task<Portofolio> CreateAsync(Portofolio portofolio);
        Task<Portofolio> DeletePortofolio(AppUser appUser, string symbol);
    }
}