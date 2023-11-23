using System;

class Program {
  public static void Main (string[] args) {
    
    //Instancias de Empleado y Gerente
    Empleado empleado = new Empleado(){
      Nombre = "Juan", Salario = 50000;
    };
    Gerente gerente = new Gerente() { Nombre = "Maria", Salario = 70000, Departamento = "Ventas" };

}