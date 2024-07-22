using Homework3_Solution.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Homework3_Solution.Pages;

public class CheckoutModel : PageModel
{
    private readonly ILogger<CheckoutModel> _logger;

    [BindProperty]
    public Order OrderItem {get; set;} = default!;

    public CheckoutModel(ILogger<CheckoutModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            _logger.LogWarning("OnPost() - INVALID Model State.");
            return RedirectToPage("/Checkout");
        }

        _logger.LogWarning($"OnPost() - Model State Valid. Country: {OrderItem.Country} - {OrderItem.State}");
        return Page();
    }
}
