using BS02.Application.Contract;
using BS02.Application.Contract.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BS05.Personation.MVCCore
{
    public class CreateModel : PageModel
    {
        private readonly IBookAppliaction bookAppliaction;

        public CreateModel(IBookAppliaction bookAppliaction)
        {
            this.bookAppliaction = bookAppliaction;
        }

        public void OnGet()
        {
        }

        public RedirectToPageResult OnPost(CreateBookDto command)
        {
            bookAppliaction.Create(command);
            return RedirectToPage("./List");
        }
    }
}
