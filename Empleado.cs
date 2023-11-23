class Empleado : IMostrarInformacion{
  public string Nombre { get; set; }
  public double Salario { get; set; }

  public double CalcularSalarioAnual() {
    return Salario * 12;
  }

  public void mostrarInformacionGeneral(){
    
  }
}