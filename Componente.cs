using System;
using System.Collections.Generic;

abstract class Componente
{
    protected string nombre;

    public Componente(string nombre)
    {
        this.nombre = nombre;
    }

    public abstract void MostrarInformacion(int nivel);
}