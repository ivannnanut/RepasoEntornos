using RepasoEntornos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoEntornos.Models
{
    class Tablet : Dispositivo
    {

        public Tablet(string marca, string modelo, float pulgadas, string sistema, float precio) : base(marca, modelo,pulgadas, sistema, precio)
        {

        }
    }
}
