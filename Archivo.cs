using System;
using System.Collections.Generic;
class Archivo : Componente
{
    public Archivo(string nombre) : base(nombre)
    {
    }

    public override void MostrarInformacion(int nivel)
    {
        Console.WriteLine(new string('-', nivel) + nombre);
    }
}