using Library.GeneralInterface;

namespace Library.AudioBook;

public interface IAudioBook: ILibraryItem
{
     int RuntimeInMinutes { get; set; }
}