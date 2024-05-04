var sale = new Sale();
var beer = new Beer();

Some(sale); // Se guardó en la BD
Some(beer); // Se guardó en Servicio


// Función que ejecuta el método `Save`
void Some(ISave save)
{
    save.Save();
}


// Interfaz que solicitará que halla una propiedad `Total`
interface ISale
{
    decimal Total { get; set; }
}

// Interfaz que solicitará que halla un método `Save`
interface ISave
{
    public void Save();
}


// Clase `Sale` que requiere cumplir con las interfaces implementadas
public class Sale : ISale, ISave
{
    public decimal Total { get; set; } // Cumple con `ISale`

    public void Save() // Cumple con `ISave`
    {
        Console.WriteLine("Se guardó en la BD");
    }
}

// Clase `Beer` que require cumplir con la interfaz `ISave`
public class Beer : ISave
{
    public void Save() // Cumple con la interfaz implementada
    {
        Console.WriteLine("Se guardó en Servicio");
    }
}