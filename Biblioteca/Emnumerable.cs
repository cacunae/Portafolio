using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{

    public enum Estado
    {
        Vigente,
        Vencido
    }

    public enum Origen
    {
        Nacional,
        Internacional
    }

    public enum Transporte
    {
        Maritimo,
        Aereo,
        Terrestre
    }

    public enum Licencia
    {
        Clase_A,
        Clase_B,
        Clase_C
    }

}
