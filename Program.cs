using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    internal class Program
    {

        static void Main(string[] args)
        {
            
            Dictionary <int ,string > inventario = new Dictionary<int ,string>();

            inventario.Add(2601, " Audifonos");
            inventario.Add(1995," Monitor 4k");
            inventario.Add(2001, " Mouse ");
            inventario.Add(1959, " disco solido");

            Console.WriteLine(" inventario actual");
            foreach (var item in inventario)
            {
                Console.WriteLine(item.Key + item.Value);

            }

            Console.WriteLine(" ingrese el codigo del producto que desea eliminar");
            int BuscarCod = int.Parse(Console.ReadLine());

            if (inventario.Remove(BuscarCod))
            {
                Console.WriteLine("producto eliminado");

            }
            else
            {
                Console.WriteLine(" el codigo no existe ");

            }

            Console.WriteLine("inventario actualizado");
            foreach(var item in inventario)
            {
                Console.WriteLine(item.Key+ item.Value);
            }


        }
    }
}
