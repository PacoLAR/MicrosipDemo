using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EstilosMicrosipDemo.Models;
using Microsoft.AspNetCore.Components;
namespace EstilosMicrosipDemo.Components.Base
{
    public class CfdiComponentBase : ComponentBase
    {
        public List<CfdiItem> cfdiItems = new List<CfdiItem>()
        {
            new CfdiItem{Clave_Uso_Cfdi ="G01",Descripcion="Adquisicion de mercancias",Fisica=true,Moral=true },
            new CfdiItem{Clave_Uso_Cfdi ="G02",Descripcion="Devoluciones, descuentos o bonificaciones",Fisica=true,Moral=true },
            new CfdiItem{Clave_Uso_Cfdi ="G03",Descripcion="Gastos General",Fisica=true,Moral=true },
            new CfdiItem{Clave_Uso_Cfdi ="I01",Descripcion="Construcciones",Fisica=true,Moral=true },
            new CfdiItem{Clave_Uso_Cfdi ="I02",Descripcion="Mobiliario y equipo de oficina por inversiones",Fisica=true,Moral=true },
            new CfdiItem{Clave_Uso_Cfdi ="I03",Descripcion="Equipo de transporte",Fisica=true,Moral=true },
            new CfdiItem{Clave_Uso_Cfdi ="I04",Descripcion="Equipo de computo y accesorios",Fisica=true,Moral=true },
            new CfdiItem{Clave_Uso_Cfdi ="I05",Descripcion="Dados,troqueles, moldes, matrices y herramental",Fisica=true,Moral=true },
            new CfdiItem{Clave_Uso_Cfdi ="I06",Descripcion="Comunicaciones telefónicas",Fisica=true,Moral=true },
            new CfdiItem{Clave_Uso_Cfdi ="I07",Descripcion="Comunicaciones satelitales",Fisica=true,Moral=true },
            new CfdiItem{Clave_Uso_Cfdi ="I08",Descripcion="Otra maquinaria y equipo",Fisica=true,Moral=true },

        };
    }
}
