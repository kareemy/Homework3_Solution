using Homework3_Solution.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Homework3_Solution.Pages;

public class ConfirmationModel : PageModel
{
    private readonly ILogger<ConfirmationModel> _logger;

    [BindProperty]
    public Order OrderItem {get; set;} = default!;

    public ConfirmationModel(ILogger<ConfirmationModel> logger)
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
