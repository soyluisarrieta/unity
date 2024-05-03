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