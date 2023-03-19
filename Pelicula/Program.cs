using System;
using System.Collections.Generic;

namespace Pelicula
{

    public class Pelicula
    {
        //Campos
        private string titulo;
        private int año;
        private string pais;
        private string director;

        private List<Actor> actores = new List<Actor>();

        //Constructores
        public Pelicula();

        public Pelicula(string titulo,int año)
        {
            this.titulo=titulo;
            this.año=año;
        }
     
        //Métodos
        public string GetTitulo(){return titulo;}
        public void SetTitulo(string tit){titulo=tit;}

        public int GetAño(){return año;}
        public void SetAño(int añ){año=añ;}
        public string GetPais(){return pais;}
        public void SetPais(string pa){pais=pa;}
        public string GetDirector(){return director;}
        public void SetDirector(string dir){director=dir;}

        public void Imprime()
        {
            Console.WriteLine($"{titulo} ({año})");

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
            //Console.WriteLine($"{Nombre} ({Año})");
        }
    }

    // Puedes probar tu código en Main() pero lo importante
    // es que pase las pruebas

    class Program
    {


        static void Main(string[] args)
        {
            Pelicula p1=new Pelicula();
            Pelicula p2=new Pelicula();
            /*p1.titulo="Pinocchio";
            p1.año=2022;
            p1.pais="Estados Unidos";
            p1.director="Guillermo del Toro";
            p2.titulo="Everything Everywhere All At Once";
            p2.año=2022;
            p2.pais="Estados Unidos";
            p2.director="Russo Brothers";
            Console.WriteLine("{0} - {1}", p1.titulo, p1.año);
            Console.WriteLine("{0} - {1}", p2.titulo, p2.año);*/

            p1.SetTitulo("La La Land");
            p1.SetAño(2016);
            Console.WriteLine("{0} ({1})", p1.GetTitulo(), p1.GetAño());
        }
    }
}
