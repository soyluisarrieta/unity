var sale = new SaleWithTax(15, 1.16m);
var message = sale.GetInfo();
var messageWithDiscount = sale.GetInfo(77);

Console.WriteLine(message); // El total es: 15 con un impuesto de: 1.16
Console.WriteLine(messageWithDiscount); // El total es: 15 con un impuesto de: 1.16, con descuento del 77%

// Clase con herencia
class SaleWithTax : Sale
{
    public decimal Tax { get; set; }

    public SaleWithTax(decimal total, decimal tax) : base(total)
    {
        Tax = tax;
    }

    public override string GetInfo()
    {
        return $"El total es: {Total} con un impuesto de: {Tax}";
    }

    // Es posible crear una sobrecarga con mismo nombre y parámetros distintos.
    public string GetInfo(int discount)
    {
        return $"El total es: {Total} con un impuesto de: {Tax}, con descuento del {discount}%";
    }
}

// Clase principal
class Sale
{
    public decimal Total { get; set; }

    public Sale (decimal total)
    {
        Total = total;
    }

    // Con `virtual` indicamos que el método puede ser sobreescrito
    public virtual string GetInfo()
    {
        return "El total es: " + Total;
    }
}