using System;

class MainClass {
  public static void Main (string[] args) {

    //array implicito
    //no especifica el tipo de dato ni posicion ni elementos del array
    var valores = new[] {3, 6, 8.5, 8.2,9, 7.5};//pasará todo a array tipo double 3.0, 6.0, etc
    Console.WriteLine(valores[3]);

    //var datos = new [] {"Juan", "Díaz", "España", 15};//no pasará tipo de array por contener diferente tipos de valores: string y int

    //array Empleados
		Empleados [] arrEmpleados = new Empleados[2];
		//construir en el objeto mientras lo almacenamos  dentro el array (2 pasos en 1)alternativa 1
		arrEmpleados[0] = new Empleados("Oscar", 40);  
		
		//crear el objeto y una vez creado el obj almacenarlo en una posicion del array/alternativa 2
		Empleados Oscar = new Empleados("Oscar", 40);
		arrEmpleados[1] = Oscar;

		var Personas = new []{
			new {Nombre = "Oscar", Edad = 40},
			new {Nombre = "Vernita", Edad = 6},
			new {Nombre = "Francisco", Edad = 2},		
		};
		Console.WriteLine(Personas[1]);
  }
	
  //array de objeto
  class Empleados{
    public Empleados(string nombre, int edad){
      this.nombre = nombre;
      this.edad = edad;
    }
		string nombre;
		int edad;
  }


}