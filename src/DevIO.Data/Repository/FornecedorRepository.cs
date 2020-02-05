using AppMvcBasica.Models;
using DevIO.Business.Interfaces;
using DevIO.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Data.Repository
{
    public class FornecedorRepository : Repository<Fornecedor>, IFornecedorRepository
    {
        public FornecedorRepository(MeuDbContext context) : base(context){ }

        public async Task<Fornecedor> ObterFornecedorEndereco(Guid id)
        {
            return await db.Fornecedores.AsNoTracking().Include(f => f.Endereco).FirstOrDefaultAsync(e=>e.Id == id);
        }

        public async Task<Fornecedor> ObterFornecedorProdutosEndereco(Guid id)
        {
            return await db.Fornecedores.AsNoTracking()
                .Include(p => p.Produtos)
                .Include(e => e.Endereco).FirstOrDefaultAsync(c=>c.Id == id); 
        }
    }
}
