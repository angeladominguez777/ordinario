﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordinario
{
    internal interface IAcciones
    {
        List<Auto> MostrarAutos();
        bool Agregar(int Id2, string marca2, string modelo2, int anio2, string color2, double precio2, string estado2);
        bool Actualizar(int Id, string marca, string modelo, int anio, string color, double precio, string estado);

        bool Eliminar(int id);


        bool ExportarExcel();

        bool Importar();
    }
}
