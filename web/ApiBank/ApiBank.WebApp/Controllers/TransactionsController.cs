using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ApiBank.Databases;
using ApiBank.Models;

namespace ApiBank.WebApp.Controllers
{
    public class TransactionsController : Controller
    {
        private readonly BankDbContext _context;



        public TransactionsController()
        {
            _context = new();
        }

        // GET: Transactions
        public async Task<IActionResult> Index()
        {
              return _context.BankTransactions != null ? 
                          View(await _context.BankTransactions.ToListAsync()) :
                          Problem("Entity set 'BankDbContext.BankTransactions'  is null.");
        }

        // GET: Transactions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.BankTransactions == null)
            {
                return NotFound();
            }

            var bankTransaction = await _context.BankTransactions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bankTransaction == null)
            {
                return NotFound();
            }

            return View(bankTransaction);
        }

        // GET: Transactions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Transactions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TransactionDate,TransactionFrom,TransactionTo,TransactionAmount,Id")] BankTransaction bankTransaction)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bankTransaction);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bankTransaction);
        }

        // GET: Transactions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.BankTransactions == null)
            {
                return NotFound();
            }

            var bankTransaction = await _context.BankTransactions.FindAsync(id);
            if (bankTransaction == null)
            {
                return NotFound();
            }
            return View(bankTransaction);
        }

        // POST: Transactions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, [Bind("TransactionDate,TransactionFrom,TransactionTo,TransactionAmount,Id")] BankTransaction bankTransaction)
        {
            if (id != bankTransaction.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bankTransaction);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BankTransactionExists(bankTransaction.Id))
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
            return View(bankTransaction);
        }

        // GET: Transactions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.BankTransactions == null)
            {
                return NotFound();
            }

            var bankTransaction = await _context.BankTransactions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bankTransaction == null)
            {
                return NotFound();
            }

            return View(bankTransaction);
        }

        // POST: Transactions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (_context.BankTransactions == null)
            {
                return Problem("Entity set 'BankDbContext.BankTransactions'  is null.");
            }
            var bankTransaction = await _context.BankTransactions.FindAsync(id);
            if (bankTransaction != null)
            {
                _context.BankTransactions.Remove(bankTransaction);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BankTransactionExists(int? id)
        {
          return (_context.BankTransactions?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
