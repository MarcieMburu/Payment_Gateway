using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Payment_Gateway.Data;
using Payment_Gateway.Models;

namespace Payment_Gateway.Controllers
{
    public class SendersController : Controller
    {
        private readonly Payment_GatewayContext _context;

        public SendersController(Payment_GatewayContext context)
        {
            _context = context;
        }

        // GET: Senders
        public async Task<IActionResult> Index()
        {
              return _context.Sender != null ? 
                          View(await _context.Sender.ToListAsync()) :
                          Problem("Entity set 'Payment_GatewayContext.Sender'  is null.");
        }

        // GET: Senders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Sender == null)
            {
                return NotFound();
            }

            var sender = await _context.Sender
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sender == null)
            {
                return NotFound();
            }

            return View(sender);
        }

        // GET: Senders/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Senders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Sen_Name,Sen_ID_NO,Sen_Phone,Sen_Src_Acc")] Sender sender)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sender);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sender);
        }

        // GET: Senders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Sender == null)
            {
                return NotFound();
            }

            var sender = await _context.Sender.FindAsync(id);
            if (sender == null)
            {
                return NotFound();
            }
            return View(sender);
        }

        // POST: Senders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Sen_Name,Sen_ID_NO,Sen_Phone,Sen_Src_Acc")] Sender sender)
        {
            if (id != sender.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sender);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SenderExists(sender.Id))
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
            return View(sender);
        }

        // GET: Senders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Sender == null)
            {
                return NotFound();
            }

            var sender = await _context.Sender
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sender == null)
            {
                return NotFound();
            }

            return View(sender);
        }

        // POST: Senders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Sender == null)
            {
                return Problem("Entity set 'Payment_GatewayContext.Sender'  is null.");
            }
            var sender = await _context.Sender.FindAsync(id);
            if (sender != null)
            {
                _context.Sender.Remove(sender);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SenderExists(int id)
        {
          return (_context.Sender?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
