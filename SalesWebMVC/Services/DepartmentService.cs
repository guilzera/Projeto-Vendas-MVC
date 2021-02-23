using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMVC.Data;
using SalesWebMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMVC.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMVCContext _context; //Dependencia para o dbcontext

        public DepartmentService(SalesWebMVCContext context) //Injeção possa ocorrer
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync() //Retorna uma lista com todos os vendedores do banco de dados
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
