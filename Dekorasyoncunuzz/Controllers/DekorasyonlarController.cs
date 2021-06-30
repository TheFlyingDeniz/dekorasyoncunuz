using Dekorasyoncunuz.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Dekorasyoncunuz.Controllers
{
    public class DekorasyonlarController : Controller
    {
        private readonly DataContext _context;
        string tv = "";
        string koltuk = "";
        string yatak = "";
        string yemek = "";
        string vivense = "";
        string divanev = "";
        string modalife = "";
        string evmoda = "";


        public DekorasyonlarController(DataContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(FilterModel model)
        {
            if (model.tv)
            {
                tv = "Tv Ünitesi";
            }
            if (model.koltuk)
            {
                koltuk = "Koltuk Takımı";
            }
            if (model.yatak)
            {
                yatak = "Yatak Odası Takımı";
            }
            if (model.yemek)
            {
                yemek = "Yemek Odası Takımı";
            }
            if (model.vivense)
            {
                vivense = "Vivense";
            }
            if (model.divanev)
            {
                divanev = "Divanev";
            }
            if (model.modalife)
            {
                modalife = "Modalife";
            }
            if (model.evmoda)
            {
                evmoda = "Evmoda";
            }

            var dekorasyon = from d in _context.Dekorasyonlar
                             where d.Dekorasyon_fiyat < model.fiyat
                             &&
                             (d.Dekorasyon_marka == vivense || d.Dekorasyon_marka == divanev || d.Dekorasyon_marka == modalife || d.Dekorasyon_marka == evmoda)
                             &&
                             (d.Dekorasyon_cinsi == tv || d.Dekorasyon_cinsi == koltuk || d.Dekorasyon_cinsi == yemek || d.Dekorasyon_cinsi == yatak)
                             select d;

            if (!dekorasyon.Any())
            {
                Console.WriteLine("bumbum");
            }
            return View(await dekorasyon.ToListAsync());
        }

        // GET: Dekorasyonlar/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dekorasyon = await _context.Dekorasyonlar.FirstOrDefaultAsync(m => m.Dekorasyon_id == id);
            if (dekorasyon == null)
            {
                return NotFound();
            }

            return View(dekorasyon);
        }

        // GET: Dekorasyonlar/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Dekorasyonlar/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Dekorasyon_id,Dekorasyon_fiyat,Dekorasyon_isim,Dekorasyon_cinsi,Dekorasyon_marka")] Dekorasyon dekorasyon)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dekorasyon);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dekorasyon);
        }

        // GET: Dekorasyonlar/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dekorasyon = await _context.Dekorasyonlar.FindAsync(id);
            if (dekorasyon == null)
            {
                return NotFound();
            }
            return View(dekorasyon);
        }

        // POST: Dekorasyonlar/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Dekorasyon_id,Dekorasyon_fiyat,Dekorasyon_isim,Dekorasyon_cinsi,Dekorasyon_marka")] Dekorasyon dekorasyon)
        {
            if (id != dekorasyon.Dekorasyon_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dekorasyon);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DekorasyonExists(dekorasyon.Dekorasyon_id))
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
            return View(dekorasyon);
        }

        // GET: Dekorasyonlar/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dekorasyon = await _context.Dekorasyonlar
                .FirstOrDefaultAsync(m => m.Dekorasyon_id == id);
            if (dekorasyon == null)
            {
                return NotFound();
            }

            return View(dekorasyon);
        }

        // POST: Dekorasyonlar/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dekorasyon = await _context.Dekorasyonlar.FindAsync(id);
            _context.Dekorasyonlar.Remove(dekorasyon);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DekorasyonExists(int id)
        {
            return _context.Dekorasyonlar.Any(e => e.Dekorasyon_id == id);
        }
    }
}