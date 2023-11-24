using System;

class Gerente : Empleado, IMostrarInformacion {
  public string Departamento { get; set; }
  //Implementación de la interfaz
  public new void mostrarInformacionGeneral(){
    Console.WriteLine("Nombre: " + Nombre + ", Salario: $" + Salario+", Departamento: "+Departamento);
  }
}