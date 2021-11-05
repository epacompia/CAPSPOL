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
    public class PoliceStationsController: Controller
    {
        private readonly DataContext _context;

        public PoliceStationsController(DataContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.PoliceStations.Where(x=>x.Flag==true).ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PoliceStation policeStation)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.PoliceStations.Add(policeStation);
                    policeStation.Flag = true;
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateException dbUpdateException)
                {

                    if (dbUpdateException.InnerException.Message.Contains("duplicate"))
                    {
                        ModelState.AddModelError(string.Empty,"La comisaria ya existe en la base de datos");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "La comisaria ya existe en la base de datos");
                    }
                }
                catch(Exception exception)
                {
                    ModelState.AddModelError(string.Empty, exception.Message);
                }
            }

            return View(policeStation);
        }


        public async Task<IActionResult> Edit(int? id)
        {

            if (id==null)
            {
                return NotFound();
            }
            PoliceStation policeStation = await _context.PoliceStations.FindAsync(id);
            if (policeStation==null)
            {
                return NotFound();
            }
            return View(policeStation);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, PoliceStation policeStation)
        {
            if (id!=policeStation.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _context.PoliceStations.Update(policeStation);
                    policeStation.Flag = true;
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateException dbUpdateException)
                {
                    if (dbUpdateException.InnerException.Message.Contains("duplicate"))
                    {
                        ModelState.AddModelError(string.Empty, "La Comisaria ya existe en la base de datos");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "La Comisaria ya existe en la base de datos");
                    }

                }
                catch (Exception exception)
                {
                    ModelState.AddModelError(string.Empty, exception.Message);
                }
            }
            return View(policeStation);
        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (id==null)
            {
                return NotFound();
            }

            PoliceStation policeStation = await _context.PoliceStations.FirstOrDefaultAsync(x => x.Id == id);
            policeStation.Flag = false;
            if (policeStation==null)
            {
                return NotFound();
            }

            _context.PoliceStations.Update(policeStation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
