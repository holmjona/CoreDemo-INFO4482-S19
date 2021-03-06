﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CoreDemo.Models;
using CoreDemo.Data;

namespace CoreDemo.Controllers
{
    public class ActorController : Controller
    {
         //private readonly DeleteMeContext _context;

        public ActorController(DeleteMeContext context)
        {
            //_context = context;
        }

        // GET: Actor
        public async Task<IActionResult> Index()
        {
            return View(FakeDAL.GetActors());
        }

        // GET: Actor/Details/5
        public async Task<IActionResult> Details(int? id, string color)
        {
            if (id == null)
            {
                return NotFound();
            }

            var actor = FakeDAL.GetActor((int)id); //= await _context.Actor
                //.FirstOrDefaultAsync(m => m.ID == id);
            if (actor == null)
            {
                return NotFound();
            }

            return View(actor);
        }

        // GET: Actor/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Actor/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Title,HairColor")] Actor actor)
        {
            if (ModelState.IsValid)
            {
                //_context.Add(actor);
                //await _context.SaveChangesAsync();
                FakeDAL.Add(actor);
                return RedirectToAction(nameof(Index));
            }
            return View(actor);
        }

        // GET: Actor/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var actor = FakeDAL.GetActor((int)id); //= await _context.Actor.FindAsync(id);
            if (actor == null)
            {
                return NotFound();
            }
            return View(actor);
        }

        // POST: Actor/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Title,HairColor,SomeValue")] Actor actor)
        {
            if (id != actor.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    //_context.Update(actor);
                    //await _context.SaveChangesAsync();
                    FakeDAL.Edit(actor);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ActorExists(actor.ID))
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
            return View(actor);
        }
        
      

        // GET: Actor/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var actor = await _context.Actor
        //        .FirstOrDefaultAsync(m => m.ID == id);
        //    if (actor == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(actor);
        //}

        //// POST: Actor/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var actor = await _context.Actor.FindAsync(id);
        //    _context.Actor.Remove(actor);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        private bool ActorExists(int id)
        {
            return FakeDAL.GetActors().Any(e => e.ID == id);
        }
    }
}
