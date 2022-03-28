using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySQLFun.Models
{
    public class EFRecipesRepository : IRecipesRepository
    {
        private RecipesDbContext _context { get; set; }
        public EFRecipesRepository(RecipesDbContext temp)
        {
            _context = temp;
        }

        public IQueryable<Recipe> Recipes => _context.Recipes;
    }
}
