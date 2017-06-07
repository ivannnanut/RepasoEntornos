using RepasoEntornos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoEntornos.Models
{
    class Ordenador : Dispositivo
    {
        public string fuente_Alimentacion { get; set; }
        public List<string> Piezas { get; set; }
        public string RAM { }

        public Ordenador(string marca, string modelo, float pulgadas, string sistema, float precio) : base(marca, modelo,pulgadas, sistema, precio)
        {

        }

    }
}
