﻿using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Mwh.Sample.Web.Pages.EmployeeRazor
{
    /// <summary>
    /// Model for the employee listing page in Razor Pages
    /// </summary>
    public class IndexModel : PageModel
    {
        private readonly EmployeeContext _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexModel"/> class
        /// </summary>
        /// <param name="context">Database context for employee data</param>
        public IndexModel(EmployeeContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Gets or sets the collection of employees to display
        /// </summary>
        public IList<Employee> Employee { get; set; } = default!;

        /// <summary>
        /// Handles GET requests to load and display the list of employees
        /// </summary>
        /// <returns>A task representing the asynchronous operation</returns>
        public async Task OnGetAsync()
        {
            if (_context.Employees != null)
            {
                Employee = await _context.Employees
                .Include(e => e.Department).ToListAsync();
            }
        }
    }
}
