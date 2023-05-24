using BS02.Application.Contract;
using BS02.Application.Contract.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BS05.Personation.MVCCore
{
    public class ListModel : PageModel
    {
        public List<BookDto> Books { get; set; }
        private readonly IBookAppliaction bookAppliaction;

        public ListModel(IBookAppliaction bookAppliaction)
        {


            this.bookAppliaction = bookAppliaction;
        }

        public void OnGet()
        {
            // new List<BookDTO>() { new BookDTO() { Id = 1, Title = "C# 12", IsDeleted = false } }
            Books =  bookAppliaction.GetBooks();
        }

        public RedirectToPageResult OnPostRemove(int id)
        {

            bookAppliaction.Remove(id);
            return RedirectToPage("./List");
        }
        public RedirectToPageResult OnPostActivate(int id)
        {
            bookAppliaction.Activate(id);
            return RedirectToPage("./List");


        }
    }
}
