# Unity

## 🔥 Ejercicios

|Núm.|Nombre del Proyecto|Código|
|-|-|-|
|`01`|Hello World| [Ver](./exercises/01.hello-world/Program.cs)|
|`02`|Hello World with OOP| [Ver](./exercises//02.hello-world-POO/Program.cs)|
|`03`|Basic Sintax| [Ver](./exercises/03.basic-syntax/Program.cs)|
|`04`|Sales OOP| [Ver](./exercises/04.sales-OOP/Sales/Program.cs)|
|`05`|Using Interfaces| [Ver](./exercises/05.sales-interfaces/Program.cs)|
|`06`|Generic types| [Ver](./exercises/06.generics-type/Program.cs)|
|`07`|JSON Serialization and Diserialization| [Ver](./exercises/07.json-serialization-and-seserialization/Program.cs)|
|`08`|LINQ| [Ver](./exercises/08.LINQ/Program.cs)|
|`09`|||
|`10`|||

## Temario

1. [**Fundamentos de programación**](#Fundamentos-de-programación):
   - [x] Conceptos básicos de programación en C#.
   - [x] Estructuras de control (condicionales, bucles, etc.).
   - [x] Funciones y métodos.
   - [x] Programación orientada a objetos (clases, objetos, herencia, etc.).

2. [**Entorno de desarrollo Unity**](#entorno-de-desarrollo-unity):
   - [ ] Interfaz de usuario de Unity.
   - [ ] Manejo de proyectos en Unity (creación, organización, etc.).
   - [ ] Gestión de escenas y activos.

3. [**Creación de juegos 2D y 3D**](#Creación-de-juegos-2D-y-3D):
   - [ ] Creación y manipulación de objetos en 2D y 3D.
   - [ ] Físicas y colisiones.
   - [ ] Animaciones.
   - [ ] Sistemas de partículas.

4. [**Gráficos y efectos visuales**](#Gráficos-y-efectos-visuales):
   - [ ] Iluminación y sombreado.
   - [ ] Materiales y texturas.
   - [ ] Post-procesamiento.
   - [ ] Uso de shaders.

5. [**Sonido y música**](#Sonido-y-música):
   - [ ] Integración de efectos de sonido.
   - [ ] Música de fondo y sonidos ambientales.
   - [ ] Uso de herramientas de audio en Unity.

6. [**Redes y multiplayer**](#redes-y-multiplayer):
   - [ ] Implementación de juegos multijugador.
   - [ ] Comunicación entre clientes y servidor.
   - [ ] Sincronización de estados de juego.

7. [**Publicación y distribución**](#Publicación-y-distribución):
   - [ ] Compilación y exportación de juegos para diversas plataformas.

## 📘 Notas

### Fundamentos de programación

La idea de ver los siguientes cursos es que van desde cero, algo más intermedio y algo relacionado directamente a Unity. Con esto me concentraré únicamente en aprender primero C# y luego en como aplicarlo a Unity.

|Nombre del curso|Enlace|
|-|-|
|C# Desde Cero: Primeros Pasos|[YouTube](https://youtu.be/L-f8u0hwi4Y)|
|CURSO DE C# .NET GRATIS (Intensivo)|[YouTube](https://youtu.be/j8sxDnr7nPY)|
|Curso C# para UNITY|[YouTube](https://youtu.be/-kVmvr2UERU)|

#### ▶️ Sobre C\#

C# un lenguaje de programación multiplataforma desarrollado y estandarizado por **Microsoft** como parte de su plataforma .NET en el año 2000. Algunos usos habituales son:

1. Aplicaciones y servicios web
2. Aplcaciones nativas para Windows, MacOS, iOS y Android
3. Crear o consumir servicios en la nube
4. Crear microservicios
5. Aprendizaje automático
6. Desarrollo de juegos
7. Entre otros...

#### ▶️ Instalaciones

1. [Marco multiplataforma .Net](https://dotnet.microsoft.com/es-es/download)
2. [VSCode](https://code.visualstudio.com/download) y las extensiones:
   1. [C#](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp)
   2. [C# Dev Kit](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csdevkit)
3. [Visual Studio Community](https://visualstudio.microsoft.com/es/downloads/) y en la cargas de trabajo seleccionar "**Desarrollo de juegos con Unity**"

#### ▶️ Crear proyecto nuevo y ejecutarlo por consola

Crear la carpeta del proyecto, abrir una terminal dentro y ejecutar:

```bash
dotnet new console
```

Ahora para ejecutar el código generado por .net:

```bash
dotnet run
```

Con esto aparecerá el Hello Word que generó .net

#### ▶️ Estructura principal

```c#
using System;

namespace CSharpHelloWorld
{
  class HelloWord
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello, World with POO!");
    }
  }
}
```

#### ▶️ Sintaxis básica

<details>
  <summary>
  <strong>📘 Código fuente</strong> |
  <a href="./exercises/03.basic-syntax/Program.cs">📄 Ir al fichero</a>
  </summary>

  ```c#
  using System;

  namespace CSharpBasicSyntax
  {
    class BasicSyntax
    {
      static void Main(string[] args)
      {
        Console.WriteLine("Hola, C#"); // Hola, C#

        /*
        Esto es
        un comentario
        */

        string myString = "Esto es una cadena de texto";
        myString = "La cadena se puede reemplazar";
        Console.WriteLine(myString); // La cadena se puede reemplazar

        int myInt = 7;
        myInt += 10; // 🔵 es lo mismo queL: myInt = myInt + 3;
        Console.WriteLine(myInt); // 20
        Console.WriteLine(myInt - 5); // 15
        Console.WriteLine(myInt); // 20

        double myDouble = 3.5;
        Console.WriteLine(myDouble); // 3.5

        float myFloat = 2.3f;
        Console.WriteLine(myFloat); // 2.3

        Console.WriteLine(myInt + myDouble + myFloat); // 25.799999952316284

        dynamic myDynamic = 7;
        myDynamic = "Siete";
        Console.WriteLine(myDynamic); // Siete
        Console.WriteLine(myDynamic + myFloat); // Siete2.3
        myDynamic = "7";
        Console.WriteLine(myDynamic + myFloat); // 72.3

        var myInferency = "Infiere que es tipo String";
        // myInferency = 6; ❌ ES TIPO STRING
        Console.WriteLine(myInferency); // Infiere que es tipo String

        Console.WriteLine("El valor entero es: {myInt}"); // El valor entero es: {myInt}
        Console.WriteLine($"El valor entero es: {myInt}"); // El valor entero es: 20

        // 🔵 La convención para las constantes es uppercase
        const string MyConst = "Mi constante";
        // const MyConst = "Mi constante"; ❌ SE DEBE TIPAR
        Console.WriteLine(MyConst); // Mi constante


        // --- ESTRUCTURAS ---

        // var myArray = ["Luis", "Eduardo", "Arrieta", "Avilez"]; ❌ SE DEBE TIPAR
        var myArray = new string[] { "Luis", "Eduardo", "Arrieta", "Avilez" };
        Console.WriteLine(myArray); // System.String[]
        Console.WriteLine(myArray[0]); // Luis

        // Console.WriteLine(myArray[4]); ❌ NO EXISTE
        // myArray[4] = "Añadir otro elemento"; ❌ ES UN ARRAY DE LONGITUD FIJA
        // myArray[1] = "Reemplazar un elemento"; ❌ ES UN ARRAY CON VALORES FIJOS

        var myDictionary = new Dictionary<string, int> {
          {"soyluisarrieta", 27},
          {"jessiatis", 29},
          {"mouredev", 36},
        };
        Console.WriteLine(myDictionary); // System.Collections.Generic.Dictionary`2[System.String,System.Int32]
        Console.WriteLine(myDictionary["jessiatis"]); // 29

        var mySet = new HashSet<string> { "Luis", "Arrieta", "Arrieta", "Avilez" }; // 🔵 Los repetidos no los agrega
        Console.WriteLine(mySet.ToList()[2]); // Arrieta

        var myTuple = ("Esta", "Es", "Una", "Tupla");
        Console.WriteLine(myTuple); // (Esta, Es, Una, Tupla)


        // --- BUCLES ---

        for (int index = 0; index < 3; index++)
        {
          Console.WriteLine(index); /*
          0
          1
          2
          */
        }

        foreach (var myItem in myArray)
        {
          Console.WriteLine(myItem); /*
          Luis
          Eduardo
          Arrieta
          Avilez
          */
        }

        foreach (var myItem in myDictionary)
        {
          Console.WriteLine(myItem); /*
          [soyluisarrieta, 27]
          [jessiatis, 29]
          [mouredev, 36]
          */
        }

        foreach (var myItem in mySet)
        {
          Console.WriteLine(myItem); /*
          Luis
          Arrieta
          Avilez
          */
        }


        // --- FLUJOS ---

        if (myInt == 11 || 10 > 12)
        {
          myString = $"El valor de myInt sí es igual \"11\"";
        }
        else if (myInt == 12 && myInt != 11)
        {
          myString = $"El valor de myInt no es \"11\", pero sí es \"{myInt}\"";
        }
        else
        {
          myString = $"El valor de myInt no es \"11\" ni \"12\", es \"{myInt}\"";
        }
        Console.WriteLine(myString); // El valor de myInt no es "11" ni 12, es "20"


        // --- FUNCIONES ---

        MyFunction(); // Mi función ejecutada
        Console.WriteLine(MyFunctionWithReturn(7)); // 17
        var MyValueRetorned = MyFunctionWithReturn(20);
        Console.WriteLine(MyValueRetorned); // 30


        // --- CLASES ---

        var myClass = new MyClass("soyluisarrieta");
        Console.WriteLine(myClass); // CSharpBasicSyntax.MyClass
        Console.WriteLine(myClass.MyName); // soyluisarrieta
        myClass.MyName = "no-soyluisarrieta";
        Console.WriteLine(myClass.MyName); // no-soyluisarrieta

      }

      static void MyFunction()
      {
        Console.WriteLine("Mi función ejecutada");
      }

      static int MyFunctionWithReturn(int param)
      {
        return 10 + param;
      }
    }

    class MyClass
    {
      public string MyName { get; set; }

      public MyClass(string myCurrentName)
      {
        MyName = myCurrentName;
      }
    }
  }
```

</details>

#### ▶️ Algunos aspectos relevantes

1. Para las propiedades de una clase, es posible definir si se permite obtener esta propiedad `get` y si se permite modificar `set`:

    ```c#
    class Sale
    {
      // Se habilita la obtención de la propiedad Total1
      public decimal Total1 { get; }

      // Se habilita la obtención y modificación de la propiedad Total2
      public decimal Total2 { get; set; }

      // ❌ No es posible únicamente habilitar la modificación Total3
      public decimal Total3 { set; }
    }
    ```

2. Para crear un objeto, existen tres formas:

    ```c#
    // Usando el nombre de la clase dos veces
    Sale sale1 = new Sale();

    // Usando `var` en lugar de repetir el nombre de la clase
    var sale2 = new Sale(); // ⭐ Recomendada

    // Usando `new()`
    Sale sale3 = new();
    ```

3. Hay dos formas de acceder a una propiedad dentro de la clase:

    ```c#
    class Sale
    {
      // Se habilita la obtención de la propiedad Total1
      public decimal Total { get; set; }

      // Constructor
      public Sale(decimal total)
      {
        // Con this para cuando `nombre propiedad` ===  `parametro` (Total === Total)
        this.Total = total;

        // Sin this
        Total = total;
      }
    }
    ```

4. Métodos con bloque de código y métodos flecha:

    ```c#
    Console.WriteLine(Sale.SaySale1()); // Sale #1!
    Console.WriteLine(Sale.SaySale2()); // Sale #2!

    class Sale
    {
        public static string SaySale1()
        {
            return "Sale #1!";
        }

        public static string SaySale2() => "Sale #2!";
    }
    ```

5. Convención de nombres en las propiedades de la clase:

    ```c#
    class Sale
    {
      public decimal SubTotal { get; set; }
      private decimal _Total { get; set; }

      // Usar UpperCase en los métodos
      public Sale(decimal subTotal)
      {
        // Usar UpperCase en las propiedades y lowerCase en los parámetros
        SubTotal = subTotal;

        // Usar un guión bajo para las propiedades privadas
        _Total = subTotal + 10;
      }
    }
    ```

6. Concepto de Herencia, Sobre escritura y Sobre carga:
    <details>
      <summary>
      <strong>📘 Código fuente</strong> |
      <a href="./exercises/04.sales-OOP/Sales/Program.cs">📄 Ir al fichero</a>
      </summary>

      ```c#
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
      ```

    </details>

7. Concepto de Interfaces:
    <details>
      <summary>
      <strong>📘 Código fuente</strong> |
      <a href="./exercises/05.sales-interfaces/Program.cs>📄 Ir al fichero</a>
      </summary>

      ```c#
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
      ```

    </details>

8. Clases Genericas:
    <details>
      <summary>
      <strong>📘 Código fuente</strong> |
      <a href="./exercises/06.generics-type/Program.cs">📄 Ir al fichero</a>
      </summary>
  
      ```c#
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
      ```

    </details>

9. Serialización y deserialización del formato `json`:
    <details>
      <summary>
      <strong>📘 Código fuente</strong> |
      <a href="./exercises/07.json-serialization-and-seserialization/Program.cs">📄 Ir al fichero</a>
      </summary>
  
      ```c#
      using System.Text.Json;


      // Serializar un objeto a Json
      var luise1 = new People() { Name = "Luis Arrieta", Age = 27 };
      string json = JsonSerializer.Serialize(luise1);
      Console.WriteLine(json); // {"Name":"Luis Arrieta","Age":27}

      // Deserializar un Json a objeto
      string luiseJson = "{\"Name\":\"Luis Arrieta\",\"Age\":27}";
      People? luise2 = JsonSerializer.Deserialize<People>(luiseJson);
      Console.WriteLine($"{luise2?.Name} tiene {luise2?.Age} años"); // Luis Arrieta tiene 27 años

      public class People
      {
          public string Name { get; set; }
          public int Age { get; set; }
      }
      ```

    </details>

10. LINQ:
    <details>
      <summary>
      <strong>📘 Código fuente</strong> |
      <a href="./exercises/08.LINQ/Program.cs">📄 Ir al fichero</a>
      </summary>
  
      ```c#
      var names = new List<string>() { "Luis", "Jessica", "Paola", "Dalia", "Isabela", "Sebastian" };
      var namesResult1 = from name in names
                        where name.Length > 6
                        orderby name descending
                        select name;

      // Solo imprimirá los que tengan más de 6 caracteres
      foreach (var name in namesResult1)
      {
          Console.WriteLine(name);
          /* Sebastian
          * Jessica
          * Isabela 
          */
      }




      string[] otherNames = { "Luis", "Jessica", "Paola", "Dalia", "Isabela", "Sebastian" };
      var namesResult2 = from name in otherNames
                        where name.Length < 6
                        orderby name ascending
                        select name;

      // Solo imprimirá los que tengan menos de 6 caracteres
      foreach (var name in namesResult2)
      {
          Console.WriteLine(name);
          /* Dalia
          * Luis
          * Paola 
          */
      }




      string[] andOtherNames = { "Luis", "Jessica", "Paola", "Dalia", "Isabela", "Sebastian" };
      var namesResult3 = andOtherNames.Where(name => name == "Dalia" || name == "Sebastian")
                                      .OrderByDescending(name => name.Length)
                                      .Select(d=>d);

      // Solo imprimirá los que tengan sea igual a Dalia o Sebastian
      foreach (var name in namesResult3)
      {
          Console.WriteLine(name);
          /* Dalia
          * Sebastian
          */
      }
      ```

    </details>

### Entorno de desarrollo Unity

### Creación de juegos 2D y 3D

### Gráficos y efectos visuales

### Sonido y música

### Redes y multiplayer

### Publicación y distribución
