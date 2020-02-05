using AppMvcBasica.Models;
using DevIO.Business.Interfaces;
using DevIO.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Data.Repository
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(MeuDbContext _db) : base(_db) { }

        public async Task<Produto> ObterProdutoFornecedor(Guid id)
        {
            return await db.Produtos.AsNoTracking().Include(c => c.Fornecedor).FirstOrDefaultAsync(p=>p.Id == id);
        }

        public async Task<IEnumerable<Produto>> ObterProdutosFornecedores()
        {
            return await db.Produtos.AsNoTracking().Include(c => c.Fornecedor)
                .OrderBy(p=>p.Nome).ToListAsync();
        }

        public async Task<IEnumerable<Produto>> ObterProdutosPorFornecedor(Guid fornecedorId)
        {
            return await Buscar(p=>p.FornecedorId == fornecedorId);
        }
    }
}
