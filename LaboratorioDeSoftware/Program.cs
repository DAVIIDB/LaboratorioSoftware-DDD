﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioDeSoftware
{
    class Program
    {
        static void Main(string[] args)
        {
            _01_Aplicacion.TipoProductoServicio tipoProductoServicio = new _01_Aplicacion.TipoProductoServicio();
            List<_02_Dominio.Entidades.TipoProducto> listado = tipoProductoServicio.Listar();
        }
    }
}
