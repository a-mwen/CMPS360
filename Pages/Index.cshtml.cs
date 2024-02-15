using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CS5_Homework.Pages;

public class IndexModel : PageModel
{
    public string SpecialMessage { get; set; }

    public void OnGet()
    {
        int lastSuperBowlYear = 2024; 
        int currentYear = System.DateTime.Now.Year;

        if (currentYear - lastSuperBowlYear <= 5)
        {
            SpecialMessage = "The Chiefs' victory is still fresh in our memories! Celebrate their recent success!";
        }
        else
        {
            SpecialMessage = "Join us in celebrating the Kansas City Chiefs' remarkable journey!";
        }
    }
}
