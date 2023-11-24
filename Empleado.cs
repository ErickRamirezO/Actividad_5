using System;

class Empleado : IMostrarInformacion{
  public string Nombre { get; set; }
  public double Salario { get; set; }

  public double CalcularSalarioAnual() {
    return Salario * 12;
  }
  //Implementación de la interfaz
  public void mostrarInformacionGeneral(){
    Console.WriteLine("Nombre: " + Nombre + ", Salario: $" + Salario);
  }
}