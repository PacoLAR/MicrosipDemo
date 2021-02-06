using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using EstilosMicrosipDemo.Models;

namespace EstilosMicrosipDemo.Components.Base
{
    public class MonedaComponentBase : ComponentBase { 


    public List<MonedaItem> monedaItems = new List<MonedaItem>()
    {
        new MonedaItem{Id=1,Nombre="Peso mexicano",Abrev="MXN"},
        new MonedaItem{Id=2,Nombre="Dolar estadounidense",Abrev="USD"}
    };
}
}
