using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using RepositoryExample.Domain;

namespace RepositoryExample.Data
{
    public interface IProductoRepository
    {
        //Tenemos que hacer un repo que nos permita hacer un CRUD de productos. Dominio: Producto
        List<Product> GetProducts();
        Product GetById(int id);
        bool Save(Product product);
        bool Delete(int id);
    }
}
