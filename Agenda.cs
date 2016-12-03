using System;
using System.Collections;
using System.Collections.Generic;

namespace Agenda
{
    class Agenda
    {
        AVL tree = new AVL();

        public  void agenda(ArrayList id ,ArrayList nombre,ArrayList apellido,ArrayList telefono,ArrayList email )
        {
            //Declaracion de Arbol
            
            //Variables
            string ingNombre = "";
            string ingApellido = "";
            string correo = "";
            int num;
            //Generar ID Automatico
            int numID;
            numID = solicitarNumero(id);
            id.Add(numID);
            tree.Insertar(numID);


            //Ingresar nombre
            Console.WriteLine("Ingrese un nombre");
            ingNombre = Console.ReadLine();
            nombre.Add(ingNombre);
            //Ingresar apellido
            Console.WriteLine("Ingrese apellido");
            ingApellido = Console.ReadLine();
            apellido.Add(ingApellido);
            //IngresarNum
            Console.WriteLine("Ingrese un num telefonico");
            num = int.Parse(Console.ReadLine());
            telefono.Add(num);
            Console.WriteLine("Ingrese una dirreccion de correo");
            //Ingresar Correo
            correo = Console.ReadLine();
            email.Add(correo);



        }
        public void mostrar(ArrayList id, ArrayList nombre, ArrayList apellido, ArrayList telefono, ArrayList email)
        {
          
            for (int i = 0; i < nombre.Count; i++)
            {
                Console.WriteLine(id[i]+"\t"+nombre[i] + "\t" + apellido[i] + "\t" + telefono[i] + "\t" + email[i]);
            }

        }
        public void buscar(ArrayList id, ArrayList nombre, ArrayList apellido, ArrayList telefono, ArrayList email)
        {
            //Declaracion de Arbol
            
            //variables
            int index,rango;
            Console.WriteLine("Ingrese el id ");
            index = int.Parse(Console.ReadLine());
            rango = id.IndexOf(index);
            Console.WriteLine("Nombre\t\tApellido\ttelefono\tEmail");
            Console.WriteLine(nombre[rango]+"\t\t"+apellido[rango]+"\t"+telefono[rango]+"\t\t"+email[rango]);
            tree.BuscarValor(index);
            tree.ImprimirEntre();

        

        }
        public void eliminar(ArrayList id, ArrayList nombre, ArrayList apellido, ArrayList telefono, ArrayList email)
        {
      
            //variables
            int index, rango;
            mostrar(id, nombre, apellido, telefono, email);
            Console.WriteLine("Ingrese el id ");
            index = int.Parse(Console.ReadLine());
            rango = id.IndexOf(index);
            id.Remove(rango);
            nombre.Remove(rango);
            apellido.Remove(rango);
            telefono.Remove(rango);
            email.Remove(rango);
            Console.WriteLine("Dato eliminado");
            tree.Borrar(index);

        }
        public void update(ArrayList id, ArrayList nombre, ArrayList apellido, ArrayList telefono, ArrayList email)
        {
            //Declaracion de Arbol
            AVL tree = new AVL();
            //variables
            int index, rango;
            string dato;
            mostrar(id, nombre, apellido, telefono, email);
            Console.WriteLine("Ingrese el id ");
            index = int.Parse(Console.ReadLine());
            rango = id.IndexOf(index);
            id.Remove(rango);
            
            Console.WriteLine("Dato eliminado");
            tree.Borrar(index);
        }
        public void menu()
        {
            Console.WriteLine("1. Ingresar ");
            Console.WriteLine("2. Buscar ");
            Console.WriteLine("3. Eliminar");
            Console.WriteLine("4. Salir");
            
            Console.Write("Selecione una opcion :");

        }
        public int solicitarNumero()
        {
            Console.WriteLine("Ingrese un numero: ");
            string valor = Console.ReadLine();
            return int.Parse(valor);
        }
        public int numRandom(ArrayList id)
        {
            Random random = new Random();
            int randomnumber = random.Next(0, 200);
            return randomnumber;

        }
        public int solicitarNumero(ArrayList id)
        {
            int ing;
            ing = numRandom(id) ;
            Console.WriteLine("El id es "+ing);
            return ing;
        }
    }
}
