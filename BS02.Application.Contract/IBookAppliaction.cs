using BS02.Application.Contract.Dto;

namespace BS02.Application.Contract
{
    public interface IBookAppliaction
    {
        List<BookDto> GetBooks();
        void Create(CreateBookDto book);

        EditBookDto GetbyId(int id);
        void Edit(EditBookDto bookDto);

        void Remove(int id);
        void Activate(int id);
    }
}