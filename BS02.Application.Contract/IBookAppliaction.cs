using BS02.Application.Contract.Dto;

namespace BS02.Application.Contract
{
    public interface IBookAppliaction
    {
        List<BookDto> GetBooks();
    }
}