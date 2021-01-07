using System;
using System.Collections.Generic;
using System.Text;

namespace UD10_E5
{
    class Videojuego : IEntregable
    {
        private string Titulo;
        public string _Titulo { get { return Titulo; } set { Titulo = value; } }

        private int Horas;
        public int _Horas { get { return Horas; } set { Horas = value; } }

        private bool Entregado;
        public bool _Entregado { get { return Entregado; } set { Entregado = value; } }

        private string Genero;
        public string _Genero { get { return Genero; } set { Genero = value; } }

        private string Compañia;
        public string _Compañia { get { return Compañia; } set { Compañia = value; } }

        public Videojuego()
        {
            _Titulo = "";
            _Horas = 3;
            _Entregado = false;
            _Genero = "";
            _Compañia = "";
        }
        public Videojuego(string T, string C)
        {
            _Titulo = T;
            _Horas = 3;
            _Entregado = false;
            _Genero = "";
            _Compañia = C;
        }
        public Videojuego(string T, int N, string G, string C)
        {
            _Titulo = T;
            _Horas = N;
            _Entregado = false;
            _Genero = G;
            _Compañia = C;
        }

        public override string ToString()
        {
            string a = "Titulo:" + this.Titulo + "\nHoras Estimadas:" + this._Horas + "\nEntregado:" + this._Entregado + "\nGenero:" + this._Genero + "\nCompañia:" + this._Compañia;
            Console.WriteLine(a);
            return a;
        }

        public void Entregar()
        {
            this.Entregado = true;
        }
        public void Devolver()
        {
            this.Entregado = false;
        }
        public bool Entregador()
        {
            return this.Entregado;
        }
        public object CompararCon(Object a)
        {
            Videojuego A = (Videojuego)a;
            if (A._Horas > this._Horas)
            {
                return A;
            }
            else
            {
                return this;
            }
        }
    }
}
