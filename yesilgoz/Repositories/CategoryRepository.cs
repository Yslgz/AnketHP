using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Anket.Models;
using Anket.ViewModels;

namespace Anket.Repositories
{
    public class CategoryRepository : GenericRepository<Category>
    {
        public CategoryRepository(AppDbContext context) : base(context) 
        {
        }
       
    }
}
