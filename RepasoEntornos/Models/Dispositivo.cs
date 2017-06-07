using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepasoEntornos.Interfaces;

namespace RepasoEntornos.Interfaces
{
    abstract class Dispositivo : IReparable
    {
        public string Marca { get; set;}
        public string Modelo { get; set; } 
        public float Pulgadas { get; set; }
        public string Sistema_operativo { get; set; }
        public float Precio { get; set; }



        public Dispositivo(string marca,string modelo,float pulgadas,string sistema,float precio)
        {
            Marca = marca;
            Modelo = modelo;
            Pulgadas = pulgadas;
            Sistema_operativo = sistema;
            Precio = precio;
        }

        public Dispositivo(string marca,string modelo,string sistema,float precio)
        {
            Marca = marca;
            Modelo = modelo;
            Sistema_operativo = sistema;
            Precio = precio;
        }

        public void Reparar(float precio)
        {
            Console.WriteLine("Esta siendo reparado");
        }

        public override string toString()
        {
            return String.Format("{0},{1},{2},{3},{4}", Marca, Modelo, Pulgadas, Sistema_operativo, Precio);
        }

    }


}
