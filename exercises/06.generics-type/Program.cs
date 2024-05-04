// Establecer lista de tipo entero y límite de 3 elementos
var numbers = new MyList<int>(3);
numbers.Add(1);
numbers.Add(2);
numbers.Add(3);
numbers.Add(4);
numbers.Add(5);
numbers.Add(6);
Console.WriteLine(numbers.GetContent()); // 1, 2, 3,


// Establecer lista de tipo string y límite de 4 elementos
var names = new MyList<string>(4);
names.Add("Luis");
names.Add("Jessica");
names.Add("Paola");
names.Add("Eduardo");
names.Add("Dalia");
names.Add("Sebastian");
Console.WriteLine(names.GetContent()); // Luis, Jessica, Paola, Eduardo,


// Establecer lista de tipo Objeto `Beer` y límite de 2 elementos
var beers = new MyList<Beer>(2);
beers.Add(new Beer() { Name = "Poker", Price = 3000 });
beers.Add(new Beer() { Name = "OtraCerveza", Price = 5000.4m });
beers.Add(new Beer() { Name = "NoConozcoMás", Price = 7000.36m });
Console.WriteLine(beers.GetContent()); // (N: Poker - P: $3000), (N: OtraCerveza - P: $5000.4),


// Clase `MyList` con un tipo genérico para establecer el tipo de lista
public class MyList<T>
{
    private List<T> _list; // Objeto que contiene toda la lista
    private int _limit; // Límite máximo

    public MyList(int limit)
    {
        _limit = limit;
        _list = new List<T>();
    }

    // Método para agregar elementos a la lista dentro del límite
    public void Add(T element) 
    { 
        if(_list.Count < _limit)
        {
            _list.Add(element);
        }
    }

    // Obtener los elementos agregados
    public string GetContent()
    {
        string content = "";
        foreach(var element in _list)
        {
            content += element + ", ";
        }

        return content;
    }
}

public class Beer
{
    public required string Name { get; set; }
    public decimal Price { get; set; }

    public override string ToString()
    {
        return $"(N: {Name} - P: ${Price})";
    }
}