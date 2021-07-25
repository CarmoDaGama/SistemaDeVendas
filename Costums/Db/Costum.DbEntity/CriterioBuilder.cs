using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costum.DbEntity
{
    public static class CriterioBuilder
    {
        public static string ReplaceInNameTable { get; set; } = " ";
        public static Criterio<Entity> Where<Entity>(
            object parameters, 
            TipoJionCriterio tipo, string ReplaceInNameTable) where Entity :class, new()
        {
            var criterio = new Criterio<Entity>(ReplaceInNameTable);
            return criterio.Where(parameters, tipo, TipoOperador.ParcialIgual);
        }
        public static Criterio<Entity> WhereDiferente<Entity>(
            object parameters, 
            TipoJionCriterio tipo, string ReplaceInNameTable) where Entity : class, new()
        {
            var criterio = new Criterio<Entity>(ReplaceInNameTable);
            return criterio.Where(parameters, tipo, TipoOperador.Diferente);
        }
    }
}
