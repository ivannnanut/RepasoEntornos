﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoEntornos
{
    interface IReparable
    {
        float Precio { get; set; }


        void Reparar(float precio);

    }
}
