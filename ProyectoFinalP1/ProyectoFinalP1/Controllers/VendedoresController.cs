using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProyectoFinalP1.Models;

namespace ProyectoFinalP1.Controllers
{
    public class VendedoresController : Controller
    {
        private readonly FinalContext _context;

        public VendedoresController(FinalContext context)
        {
            _context = context;
        }

        // GET: Vendedores
        public async Task<IActionResult> Index(string buscar)
        {
            // Metodo para buscar en la tabla vendedor
            var usuarios = from Vendedor in _context.Vendedores select Vendedor;

            if (!String.IsNullOrEmpty(buscar))
            {
                // Metodo para buscar el nombre en la tabla vendedor
                usuarios = usuarios.Where(c => c.Nombre!.Contains(buscar) || c.Apellido!.Contains(buscar) || c.Telefono!.Contains(buscar) || c.Cedula!.Contains(buscar) || c.Salario!.Contains(buscar));
            }


            return View(await usuarios.ToListAsync());
        }

        // GET: Vendedores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendedore = await _context.Vendedores
                .FirstOrDefaultAsync(m => m.IdVendedor == id);
            if (vendedore == null)
            {
                return NotFound();
            }

            return View(vendedore);
        }

        // GET: Vendedores/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Vendedores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdVendedor,Nombre,Apellido,Telefono,Cedula,Salario")] Vendedore vendedore)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vendedore);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vendedore);
        }

        // GET: Vendedores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendedore = await _context.Vendedores.FindAsync(id);
            if (vendedore == null)
            {
                return NotFound();
            }
            return View(vendedore);
        }

        // POST: Vendedores/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdVendedor,Nombre,Apellido,Telefono,Cedula,Salario")] Vendedore vendedore)
        {
            if (id != vendedore.IdVendedor)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vendedore);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VendedoreExists(vendedore.IdVendedor))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(vendedore);
        }

        // GET: Vendedores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendedore = await _context.Vendedores
                .FirstOrDefaultAsync(m => m.IdVendedor == id);
            if (vendedore == null)
            {
                return NotFound();
            }

            return View(vendedore);
        }

        // POST: Vendedores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vendedore = await _context.Vendedores.FindAsync(id);
            if (vendedore != null)
            {
                _context.Vendedores.Remove(vendedore);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VendedoreExists(int id)
        {
            return _context.Vendedores.Any(e => e.IdVendedor == id);
        }
    }
}
