using pjDataAccess;
using pjModels;
using System;
using System.Collections.Generic;

namespace pjBusiness
{
    public class Service

    {
        RecipeRDA rdar;
        WriterRDA wdar;
        KitchenContext _context;
        public Service(KitchenContext context)
        {
            rdar = new RecipeRDA(context);
            wdar = new WriterRDA(context);
        }
        //RECIPE
        public List<Recipe> GetAll()
        {
            List<Recipe> listr = new List<Recipe>();
            listr = rdar.GetAll();
          
            
            return listr;
           
        }
        //WRITER
        public Writer GetByIdWT(int id)
        {
            return wdar.Get(id);
        }
    }
}
