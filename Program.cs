using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Program
    {
        public int solicitarNumero()
        {
            Console.WriteLine("Ingrese un numero: ");
            string valor = Console.ReadLine();
            return int.Parse(valor);
        }
        static void Main(string[] args)
        {
            Agenda datos = new Agenda();
            ArrayList id = new ArrayList();
            ArrayList nombre = new ArrayList();
            ArrayList apellido = new ArrayList();
            ArrayList telefono  = new ArrayList();
            ArrayList email = new ArrayList();
            AVL lista = new AVL();
            Program prueba = new Program();
 

            int opcion = 0;
            //Variables iniciales
            do
            {
                datos.menu();
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        
                        datos.agenda(id,nombre,apellido,telefono,email);
                        


                        break;
                    case 2:
                        datos.buscar(id, nombre, apellido, telefono, email);
                        

                        break;
                    case 3:
                        datos.eliminar(id, nombre, apellido, telefono, email);
                        
                        break;
                    case 4:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Ingrese un valor valido");
                        break;
                }

            } while (opcion!=4);
        }
        
    }

}
