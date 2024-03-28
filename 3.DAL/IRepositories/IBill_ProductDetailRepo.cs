using _3.DAL.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.DAL.IRepositories
{
    public interface IBill_ProductDetailRepo
    {
        bool Add(Bill_ProductDetail obj);
        
        List<Bill_ProductDetail> GetAll();
        
    }
}
