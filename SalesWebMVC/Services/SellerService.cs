using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMVC.Data;
using SalesWebMVC.Models;

namespace SalesWebMVC.Services
{
    public class SellerService //Classe relacionada a entidade Seller. Responsavel por realizar operações relacionadas ao Seller, implementar as regras de negocio(salvar, atualizar)
    {
        private readonly SalesWebMVCContext _context; //Dependencia para o dbcontext

        public SellerService(SalesWebMVCContext context) //Injeção possa ocorrer
        {
            _context = context;
        }

        public List<Seller> FindAll() //Retorna uma lista com todos os vendedores do banco de dados
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Seller FindById(int id)
        {
            return _context.Seller.FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();
        }
    }
}
