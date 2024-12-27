using AutoMapper;
using Microsoft.Identity.Client;
using Anket.Models;
using Anket.ViewModels;

namespace Anket.Repositories
{
    public class SurveyRepository : GenericRepository<Survey>
    {
       public SurveyRepository(AppDbContext context) : base(context) 
       { 
       }

       
    }
}
