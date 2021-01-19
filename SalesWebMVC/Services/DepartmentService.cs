using System;
using System.Collections.Generic;
using System.Linq;
using SalesWebMVC.Data;
using SalesWebMVC.Models;

namespace SalesWebMVC.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMVCContext _context; //Dependencia para o dbcontext

        public DepartmentService(SalesWebMVCContext context) //Injeção possa ocorrer
        {
            _context = context;
        }

        public List<Department> FindAll() //Retorna uma lista com todos os vendedores do banco de dados
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
