using System;

public class Invoice
{
    // Adattagok
    public int InvoiceNumber { get; set; }
    public string CustomerName { get; set; }
    public DateTime PurchaseDate { get; set; }
    public string Items { get; set; }

    // Konstruktor
    public Invoice(int invoiceNumber, string customerName, DateTime purchaseDate, string items)
    {
        InvoiceNumber = invoiceNumber;
        CustomerName = customerName;
        PurchaseDate = purchaseDate;
        Items = items;
    }

    // Metódusok

    // Fizetés művelet
    public void PayInvoice(DateTime purchaseDate)
    {
        if (purchaseDatePaid <= 0)
        {
            throw new ArgumentException("Az fizetett összegnek pozitívnak kell lennie.");
        }

        if (purchaseDatePaid > PurchaseDate)
        {
            throw new ArgumentException("A fizetett összeg nem lehet nagyobb, mint a számla összege.");
        }

        PurchaseDate -= purchaseDatePaid;
        Console.WriteLine($"A számla {purchaseDatePaid} összegű részét sikeresen kifizették. Hátralévő összeg: {PurchaseDate}");
    }

    // Számla adatainak kiíratása
    public void PrintInvoiceDetails()
    {
        Console.WriteLine($"Számla sorszám: {InvoiceNumber}");
        Console.WriteLine($"Ügyfél neve: {CustomerName}");
        Console.WriteLine($"Vásárlás dátuma: {PurchaseDate}");
        Console.WriteLine($"Vásárolt tétel: {Items}");
    }
}
