using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EstilosMicrosipDemo.Models;
using Microsoft.AspNetCore.Components;

namespace EstilosMicrosipDemo.Components.Base
{
    public class FormaDePagoComponentBase : ComponentBase
    {
        public List<FormaDePagoItem> formaDePagoItems = new List<FormaDePagoItem>()
        {
            new FormaDePagoItem{Clave="001",Nombre="Efectivo",Descripcion="Consiste en el pago realizado con dinero directamente en el establecimiento."},
            new FormaDePagoItem{Clave="002",Nombre="Cheque Nominativo",Descripcion="La empresa o persona que paga el servicio emite un cheque a nombre del beneficiado." },
            new FormaDePagoItem{Clave="003",Nombre="Transferencia Electronica de Fondos SPEI",Descripcion="Transferencia electrónica de banco a banco sin importar si son cuentahabiente de la misma institución." }
        };
    }
}
