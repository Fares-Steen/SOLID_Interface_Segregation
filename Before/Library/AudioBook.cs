namespace Library;

public class AudioBook:ILibraryItem
{
    public string Author { get; set; }
    public string Title { get; set; }
    public DateTime BorrowDate { get; set; }
    public string Borrower { get; set; }
    public int CheckOutDurationInDays { get; set; } = 14;
    public string LibraryId { get; set; }
    public int Pages { get; set; } = -1;
      public int RuntimeInMinutes { get; set; }
    public void CheckIn()
    {
        Borrower = "";
    }

    public void CheckOut(string borrower)
    {
        Borrower = borrower;
        BorrowDate=DateTime.Now;
    }

    public DateTime GetDueDate()
    {
        return BorrowDate;
    }
}