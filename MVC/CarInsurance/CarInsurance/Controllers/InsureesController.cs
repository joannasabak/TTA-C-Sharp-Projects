
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarInsurance.Models;

public class InsureesController : Controller
{
    private readonly CarInsuranceContext _context;

    public InsureesController(CarInsuranceContext context)
    {
        _context = context;
    }

    // GET: INSUREES
    public async Task<IActionResult> Index()    
    {
        return View(await _context.Insuree.ToListAsync());
    }

    public async Task<IActionResult> Admin()
    {
        var insurees = await _context.Insuree
            .OrderByDescending(i => i.Id)
            .ToListAsync();

        return View(insurees);
    }

    // GET: INSUREES/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var insuree = await _context.Insuree
            .FirstOrDefaultAsync(m => m.Id == id);
        if (insuree == null)
        {
            return NotFound();
        }

        return View(insuree);
    }

    // GET: INSUREES/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: INSUREES/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
    {
        if (ModelState.IsValid)
        {
            insuree.Quote = CalculateQuote(insuree);
            _context.Add(insuree);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(insuree);
    }

    // GET: INSUREES/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var insuree = await _context.Insuree.FindAsync(id);
        if (insuree == null)
        {
            return NotFound();
        }
        return View(insuree);
    }

    // POST: INSUREES/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
    {
        if (id != insuree.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                insuree.Quote = CalculateQuote(insuree);
                _context.Update(insuree);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InsureeExists(insuree.Id))
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
        return View(insuree);
    }

    // GET: INSUREES/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var insuree = await _context.Insuree
            .FirstOrDefaultAsync(m => m.Id == id);
        if (insuree == null)
        {
            return NotFound();
        }

        return View(insuree);
    }

    // POST: INSUREES/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var insuree = await _context.Insuree.FindAsync(id);
        if (insuree != null)
        {
            _context.Insuree.Remove(insuree);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool InsureeExists(int? id)
    {
        return _context.Insuree.Any(e => e.Id == id);
    }

    private decimal CalculateQuote(Insuree insuree)
    {
        //base amount
        decimal quote = 50m;

        //age
        int age = DateTime.Today.Year - insuree.DateOfBirth.Year;
        if (insuree.DateOfBirth.Date > DateTime.Today.AddYears(-age))
        {
            age--;
        }

        if (age <= 18)
        {
            quote += 100m;
        }
        else if (age > 18 && age <= 25)
        {
            quote += 50m;
        }
        else
        {
            quote += 25m;
        }

        //car year charges
        int carYear = insuree.CarYear;

        if (carYear < 2000)
        {
            quote += 25m;
        }
        
        if (carYear > 2015)
        {
            quote += 25m;
        }

        //car make and model charges
        string carMake = insuree.CarMake.Trim().ToLower();
        string carModel = insuree.CarModel.Trim().ToLower();

        if (carMake == "porsche")
        {
            quote += 25m;

            if (carModel == "911 carrera")
            {
                quote += 25m;
            }            
        }

        //speeding tickets charges
        int tickets = insuree.SpeedingTickets;
        quote += tickets * 10;

        //percentage surcharges
        if (insuree.DUI)
        {
            quote *= 1.25m;
        }

        if (insuree.CoverageType.Trim().ToLower() == "full")
        {
            quote *= 1.5m;
        }

        return quote;
    }
}
