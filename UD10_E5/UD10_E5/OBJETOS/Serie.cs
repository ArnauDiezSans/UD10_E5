using System;
using System.Collections.Generic;
using System.Text;

namespace UD10_E5
{
    class Serie : IEntregable
    {
        private string Titulo;
        public string _Titulo { get { return Titulo; } set { Titulo = value; } }

        private int NumTemp;
        public int _NumTemp { get { return NumTemp; } set { NumTemp = value; } }

        private bool Entregado;
        public bool _Entregado { get { return Entregado; } set { Entregado = value; } }

        private string Genero;
        public string _Genero { get { return Genero; } set { Genero = value; } }

        private string Creador;
        public string _Creador { get { return Creador; } set { Creador = value; } }

        public Serie()
        {
            _Titulo = "";
            _NumTemp = 3;
            _Entregado = false;
            _Genero = "";
            _Creador = "";
        }
        public Serie(string T, string C)
        {
            _Titulo = T;
            _NumTemp = 3;
            _Entregado = false;
            _Genero = "";
            _Creador = C;
        }
        public Serie(string T, int N, string G, string C)
        {
            _Titulo = T;
            _NumTemp = N;
            _Entregado = false;
            _Genero = G;
            _Creador = C;
        }

        public override string ToString()
        {
            string a = "Titulo:" + this.Titulo + "\nNum Temp:" + this._NumTemp + "\nEntregado:" + this._Entregado + "\nGenero:" + this._Genero + "\nCreador:" + this._Creador;
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
            Serie A = (Serie)a;
            if (A._NumTemp > this._NumTemp)
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
