using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        // Crear una estructura de carpetas y archivos
        var carpetaRaiz = new Carpeta("Raíz");
        var carpeta1 = new Carpeta("Carpeta 1");
        var carpeta2 = new Carpeta("Carpeta 2");
        var archivo1 = new Archivo("Archivo 1.txt");
        var archivo2 = new Archivo("Archivo 2.txt");
        var archivo3 = new Archivo("Archivo 3.txt");

        carpeta1.Agregar(archivo1);
        carpeta2.Agregar(archivo2);
        carpeta2.Agregar(archivo3);
        carpetaRaiz.Agregar(carpeta1);
        carpetaRaiz.Agregar(carpeta2);

        // Mostrar la información de la estructura
        carpetaRaiz.MostrarInformacion(0);

        Console.ReadLine();
    }
}