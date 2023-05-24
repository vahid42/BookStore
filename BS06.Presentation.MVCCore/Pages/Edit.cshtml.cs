using BS02.Application.Contract;
using BS02.Application.Contract.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BS05.Personation.MVCCore;
public class EditModel : PageModel
{
    [BindProperty] public EditBookDto editBook { get; set; }

    private readonly IBookAppliaction bookAppliaction;

    public EditModel(IBookAppliaction bookAppliaction)
    {
        this.bookAppliaction = bookAppliaction;
    }

    public void OnGet(int id)
    {
        editBook = bookAppliaction.GetbyId(id);
    }

    public RedirectToPageResult OnPost()
    {
        bookAppliaction.Edit(editBook);
        return RedirectToPage("./List");
    }
}
 