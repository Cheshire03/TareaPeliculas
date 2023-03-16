using System;
using System.Collections.Generic;

namespace Pelicula
{

    public class Pelicula
    {
        //Campos
        public string titulo{set;get;}
        public int año{set;get;}
        public string pais{set;get}
        public string director{set;get}

        private List<Actor> actores = new List<Actor>();

        //Constructores
        public static Pelicula(string titulo,int año,string pais,string director)
        {
            this.titulo=titulo;
            this.año=año;
            this.pais=pais;
            this.director=director;
        }
     
        //Métodos
     
        public void Imprime()
        {
     //       Console.WriteLine($"{titulo} ({año})");

        }


    }

    public class Actor
    {
        //Propiedades
        string nombre;
        int año;

        //Constructores


        //Métodos 
        public void Imprime()
        {
            Console.WriteLine($"{Nombre} ({Año})");
        }
    }

    // Puedes probar tu código en Main() pero lo importante
    // es que pase las pruebas

    class Program
    {


        static void Main(string[] args)
        {
            Pelicula p1=new Pelicula("Pinocchio",2022,);
        }
    }
}
