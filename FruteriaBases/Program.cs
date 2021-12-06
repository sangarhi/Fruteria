using Lib;
using Lib.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruteriaBases
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Fruta fruta = new Fruta();
            //CREATE
            /* Console.WriteLine("Introduzca una fruta");
             string nombre = Console.ReadLine();
             fruta.nombre = nombre;
             Console.WriteLine("Introduzca una descripción");
             string descripcion = Console.ReadLine();
             fruta.descripcion = descripcion;
             DateTime fechaModificado = DateTime.Now;
             fruta.fechaModificado = fechaModificado;

             Console.WriteLine($"La fruta introducida es {nombre} y su descripción es {descripcion} y la fecha de modificación es {fechaModificado} ");
             fruta.save();*/
            //DELETE
           /* Console.WriteLine("¿Qué fruta desea eliminar?");
            string nombre = Console.ReadLine();
            fruta.deleteByNombre(nombre);
            Console.WriteLine("Fruta borrada correctamente");*/
            Fruta fr = fruta.findById(3);
            Console.WriteLine($"La fruta encontrada es {fr.nombre} y su descripción es {fr.descripcion} y la fecha de modificación es {fr.fechaModificado} ");

           List<Fruta> frutas = fruta.findAll();
            foreach(Fruta fru in frutas)
            {
                Console.WriteLine(fru.nombre);
            }
            
        }
    }
}
