using join.Produtos.Core.Context;
using join.Produtos.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace join.Produtos.Core.Portas.Adapters
{
    public class ProdutosDAO : IProdutoDAO
    {
        private ProdutosContext _db = new ProdutosContext();

        Produto IBaseDAO<Produto>.Add(Produto obj)
        {
            _db.Set<Produto>().Add(obj);
            _db.SaveChanges();
            return obj;
        }

        public Produto GetById(int id)
        {
            return _db.Set<Produto>().Find(id);
        }

        public IEnumerable<Produto> GetAll()
        {
            return _db.Set<Produto>().ToList();
        }

        public void Update(Produto obj)
        {
            _db.Entry(obj).State = System.Data.EntityState.Modified;
            _db.SaveChanges();
        }

        public void Remove(Produto obj)
        {
            _db.Set<Produto>().Remove(obj);
            _db.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }


    }
}
