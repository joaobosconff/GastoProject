using GastoProject.DATA.Model;
using GastoProject.DATA;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GastoProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GastoController : ControllerBase
    {

        private readonly DataContext _context;

        public GastoController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<Gasto>> GetAll()
        {
            return _context.Gasto.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Gasto> GetById(int id)
        {
            return _context.Gasto.Find(id);
        }

        [HttpPost]
        public ActionResult<Gasto> Create([FromBody] Gasto gasto)
        {
            _context.Gasto.Add(gasto);
            _context.SaveChanges();
            return gasto;
        }

        [HttpPut("{id}")]
        public ActionResult<Gasto> Update(int id,[FromBody] Gasto gastoNew)
        {
            Gasto gasto = _context.Gasto.Find(id);
            gasto.Preco = gastoNew.Preco;
            gasto.Descricao = gastoNew.Descricao;
            gasto.DataDeRegistro = gastoNew.DataDeRegistro;
            _context.Entry(gasto).State = EntityState.Modified;
            _context.SaveChanges();
            return gasto;
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Gasto gasto = _context.Gasto.Find(id);
            _context.Gasto.Remove(gasto);
            _context.SaveChanges();
        }

    }
}
