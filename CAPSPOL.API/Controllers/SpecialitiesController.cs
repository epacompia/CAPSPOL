using CAPSPOL.API.Data;
using CAPSPOL.API.Data.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CAPSPOL.API.Controllers
{
    [Authorize(Roles = "Admin")]
    public class SpecialitiesController:Controller
    {
        private readonly DataContext _context;

        public SpecialitiesController(DataContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Specialities.Where(x=>x.Flag==true).ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Speciality speciality)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Specialities.Add(speciality);
                    speciality.Flag = true;
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateException dbUpdateException)
                {
                    if (dbUpdateException.InnerException.Message.Contains("duplicate"))
                    {
                        ModelState.AddModelError(string.Empty, "Ya existe esta especialidad en base de datos");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, dbUpdateException.InnerException.Message);
                    }
                   
                }
                catch(Exception excecption)
                {
                    ModelState.AddModelError(string.Empty, excecption.Message);
                }

            }
            return View(speciality);

        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id==null)
            {
                return NotFound();
            }

            Speciality speciality = await _context.Specialities.FindAsync(id);
            if (speciality==null)
            {
                return NotFound();
            }
            return View(speciality);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id , Speciality speciality)
        {
            if (id!=speciality.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Specialities.Update(speciality);
                    speciality.Flag = true;
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateException dbUpdateException)
                {
                    if (dbUpdateException.InnerException.Message.Contains("duplicate"))
                    {
                        ModelState.AddModelError(string.Empty, "La especialidad ya existe en la base de datos");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, dbUpdateException.InnerException.Message);
                    }
                    
                }
                catch(Exception exception)
                {
                    ModelState.AddModelError(string.Empty, exception.Message);
                }
            }
            return View(speciality);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id==null)
            {
                return NotFound();
            }

            Speciality speciality = await _context.Specialities.FirstOrDefaultAsync(x => x.Id == id);
            speciality.Flag = false;
            if (speciality==null)
            {
                return NotFound();
            }

            _context.Specialities.Update(speciality);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
