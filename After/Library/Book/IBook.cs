using Library.GeneralInterface;

namespace Library.Book;

public interface IBook:ILibraryItem
{
    string Author { get; set; }
    int Pages { get; set; }

}