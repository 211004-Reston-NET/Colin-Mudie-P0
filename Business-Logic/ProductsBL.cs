using System.Collections.Generic;
using Data_Access_Logic;
using Models;

namespace Business_Logic
{
    public class ProductsBL : IProductsBL
    {
        private Repository _repo;
        public ProductsBL(Repository p_repo)
        {
            _repo = p_repo;
        }

        public List<Products> GetProductsList()
        {
            return _repo.GetProductsList();
        }
    }
}