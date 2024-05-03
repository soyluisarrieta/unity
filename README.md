# Unity

## 🔥 Ejercicios

|Núm.|Nombre del Proyecto|Código|
|-|-|-|
|`01`|Hello World| [Ver](./exercises/01.hello-world/Program.cs)|
|`02`|Hello World with OOP| [Ver](./exercises//02.hello-world-POO/Program.cs)|
|`03`|Basic sintax| [Ver](./exercises/03.basic-syntax/Program.cs)|
|`04`|||
|`05`|||

## Temario

1. [**Fundamentos de programación**](#Fundamentos-de-programación):
   - [x] Conceptos básicos de programación en C#.
   - [x] Estructuras de control (condicionales, bucles, etc.).
   - [x] Funciones y métodos.
   - [ ] Programación orientada a objetos (clases, objetos, herencia, etc.).

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

#### Conceptos básicos de programación en C\#

|Nombre del curso|Enlace|
|-|-|
|C# Desde Cero: Primeros Pasos|[YouTube](https://youtu.be/L-f8u0hwi4Y)|
|CURSO DE C# .NET GRATIS (Intensivo)|[YouTube](https://youtu.be/j8sxDnr7nPY)|
|Curso C# para UNITY|[YouTube](https://youtu.be/-kVmvr2UERU)|

##### Sobre C\#

C# un lenguaje de programación multiplataforma desarrollado y estandarizado por **Microsoft** como parte de su plataforma .NET en el año 2000. Algunos usos habituales son:

1. Aplicaciones y servicios web
2. Aplcaciones nativas para Windows, MacOS, iOS y Android
3. Crear o consumir servicios en la nube
4. Crear microservicios
5. Aprendizaje automático
6. Desarrollo de juegos
7. Entre otros...

##### Instalaciones

1. [Marco multiplataforma .Net](https://dotnet.microsoft.com/es-es/download)
2. [VSCode](https://code.visualstudio.com/download) y las extensiones:
   1. [C#](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp)
   2. [C# Dev Kit](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csdevkit)
3. [Visual Studio Community](https://visualstudio.microsoft.com/es/downloads/) y en la cargas de trabajo seleccionar "**Desarrollo de juegos con Unity**"

##### Configuraciones

##### Crear proyecto nuevo y ejecutarlo por consola

Crear la carpeta del proyecto, abrir una terminal dentro y ejecutar:

```bash
dotnet new console
```

Ahora para ejecutar el código generado por .net:

```bash
dotnet run
```

Con esto aparecerá el Hello Word que generó .net

##### Estructura principal

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

##### Sintaxis básica

<details>
  <summary><strong>📘 Código fuente</strong> | <a href="./exercises/03.basic-syntax/Program.cs">Ir al fichero</a></summary>

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

### Entorno de desarrollo Unity

### Creación de juegos 2D y 3D

### Gráficos y efectos visuales

### Sonido y música

### Redes y multiplayer

### Publicación y distribución
