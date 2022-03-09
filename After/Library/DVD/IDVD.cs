using Library.GeneralInterface;

namespace Library.DVD;

public interface IDVD:ILibraryItem
{
     List<string> Actors { get; set; }
     int RuntimeInMinutes { get; set; }
}