using CAPSPOL.API.Data;
using CAPSPOL.API.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CAPSPOL.API.Controllers
{
    public class SubUnitsController:Controller
    {
        private readonly DataContext _context;

        public SubUnitsController(DataContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.SubUnits.Where(x=>x.Flag==true).ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SubUnit subUnit)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.SubUnits.Add(subUnit);
                    subUnit.Flag = true;
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateException dbUpdateException)
                {
                    if (dbUpdateException.InnerException.Message.Contains("duplicate"))
                    {
                        ModelState.AddModelError(string.Empty, "La Sub Unidad ya existe en la base de datos");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "La Sub Unidad ya existe en la base de datos");
                    }
                    
                }
                catch(Exception exception)
                {
                    ModelState.AddModelError(string.Empty,exception.InnerException.Message);
                }
            }

            return View(subUnit);
        }


        public async Task<IActionResult> Edit(int? id)
        {
            if (id==null)
            {
                return NotFound();
            }
            SubUnit subUnit = await _context.SubUnits.FindAsync(id);
            if (subUnit==null)
            {
                return NotFound();
            }
            return View(subUnit);
            
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, SubUnit subUnit)
        {
            if (id!=subUnit.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.SubUnits.Update(subUnit);
                    subUnit.Flag = true;
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateException dbUpdateException)
                {
                    if (dbUpdateException.InnerException.Message.Contains("duplicate"))
                    {
                        ModelState.AddModelError(string.Empty, "La Sub Unidad ya existe en la base de datos");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "La Sub Unidad ya existe en la base de datos");
                    }

                }
                catch (Exception exception)
                {
                    ModelState.AddModelError(string.Empty, exception.InnerException.Message);
                }
            }

            return View(subUnit);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id==null)
            {
                return NotFound();
            }
            SubUnit subUnit = await _context.SubUnits.FirstOrDefaultAsync(x=>x.Id==id);
            if (subUnit==null)
            {
                return NotFound();
            }

            _context.SubUnits.Update(subUnit);
            subUnit.Flag = false;
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

    }
}
