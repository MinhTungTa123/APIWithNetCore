using pjModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace pjDataAccess
{
   public class RecipeRDA
    {
        private KitchenContext _context;
        public RecipeRDA(KitchenContext context)
        {
            _context = context;
        }



        public List<Recipe> GetAll()
        {
            List<Recipe> listr = _context.Recipes.ToList();
            return listr;
        }
    }
}
