using System;
using System.Collections.Generic;
class Carpeta : Componente
{
    private List<Componente> componentes = new List<Componente>();

    public Carpeta(string nombre) : base(nombre)
    {
    }

    public void Agregar(Componente componente)
    {
        componentes.Add(componente);
    }

    public void Remover(Componente componente)
    {
        componentes.Remove(componente);
    }

    public override void MostrarInformacion(int nivel)
    {
        Console.WriteLine(new string('-', nivel) + nombre);

        foreach (var componente in componentes)
        {
            componente.MostrarInformacion(nivel + 1);
        }
    }
}