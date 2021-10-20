using System.Collections.Generic;
using Data_Access_Logic;
using Models;

namespace Business_Logic
{
    public class LineItemsBL : ILineItemsBL
    {
        private Repository _repo;
        public LineItemsBL(Repository p_repo)
        {
            _repo = p_repo;
        }

        public List<LineItems> GetLineItemsList(string p_store)
        {
            return _repo.GetLineItemsList(p_store);
        }
    }
}