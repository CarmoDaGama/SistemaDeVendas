using System;
using System.Collections.Generic;

namespace Costum.DbEntity
{
    public class Criterio<Entity> where Entity : class , new()
    {
        public string ReplaceInNameTable { get; set; } = " ";
        public Criterio(string replaceInNameTable)
        {
            ReplaceInNameTable = replaceInNameTable;
            NomeTabela = new Entity().GetType().Name.Replace(ReplaceInNameTable, string.Empty);
        }
        private string StringWhere { get; set; } = string.Empty;
        private string StringOrderBy { get; set; } = string.Empty;
        private string NomeTabela { get; set; }
        public TipoBaseDados Tipo { get; private set; }

        private string strParenteCurvoInit;
        private string strParenteCurvoEnd;
        public bool functionWhere(Func<object , bool> result)
        {
            //return result
            return false;
        }
        public Criterio<Entity> Where(object parameters, TipoJionCriterio tipoJoin, TipoOperador operador)
        {
            string strOperador = GetStringOperador(operador);
            if (Equals(StringWhere, string.Empty))
            {
                StringWhere = " WHERE ";
            }
            foreach (var item in parameters.GetType().GetProperties())
            {
                if (Equals(StringWhere, " WHERE "))
                {
                    StringWhere += " [" + NomeTabela + "]." + item.Name + " " + strOperador + " '" + item.GetValue(parameters) + "'";
                }
                else
                {
                    StringWhere += tipoJoin + " [" + NomeTabela + "]." + item.Name  + " " + strOperador + "'" + item.GetValue(parameters) + "'";

                }
            }

            return this;
        }
        public Criterio<Entity> And(object parmeterAnd)
        {
            return JoinCriterio(parmeterAnd, TipoJionCriterio.AND, TipoOperador.ParcialIgual);
        }
        public Criterio<Entity> AndDiferente(object parmeterAnd)
        {
            return JoinCriterio(parmeterAnd, TipoJionCriterio.AND, TipoOperador.ParcialIgual);
        }
        public Criterio<Entity> Or(object parmeterOr)
        {
            return JoinCriterio(parmeterOr, TipoJionCriterio.OR, TipoOperador.ParcialIgual);
        }
        public Criterio<Entity> OrDiferente(object parmeterOr)
        {
            return JoinCriterio(parmeterOr, TipoJionCriterio.OR, TipoOperador.Diferente);
        }
        private Criterio<Entity> JoinCriterio(object parmeter, TipoJionCriterio tipoJoin, TipoOperador  operador )
        {
            string strOperador = GetStringOperador(operador);
            if (Equals(StringWhere, string.Empty))
            {
                StringWhere = " WHERE ";
            }
            foreach (var item in parmeter.GetType().GetProperties())
            {
                if (Equals(StringWhere, " WHERE "))
                {
                    StringWhere += " [" + NomeTabela +"]."+ item.Name +" "+ strOperador + " "+ item.GetValue(parmeter) + "'";
                }
                else
                {
                    StringWhere += tipoJoin + " [" + NomeTabela + "]." + item.Name + " " + strOperador + " '" + item.GetValue(parmeter) + "'";

                }
            }
            StringWhere = TiraParentes(StringWhere);
            return this;
        }

        protected void TrocarParentesCurvos()
        {
            strParenteCurvoInit = "[";
            strParenteCurvoEnd = "]";
            if (Tipo == TipoBaseDados.MySql)
            {
                strParenteCurvoInit = string.Empty;
                strParenteCurvoEnd = string.Empty;
            }
        }
        protected string TiraParentes(string str)
        {
            TrocarParentesCurvos();
            return str.Replace("[", strParenteCurvoInit).Replace("]", strParenteCurvoEnd);
        }
        private string GetStringOperador(TipoOperador operador)
        {
            switch (operador)
            {
                case TipoOperador.ParcialIgual:
                    return " LIKE ";
                case TipoOperador.Diferente:
                    return " <> ";
                case TipoOperador.Igual:
                    return " = ";
                case TipoOperador.Maior:
                    return " > ";
                case TipoOperador.MajorOuIgual:
                    return " >= ";
                case TipoOperador.Menor:
                    return " < ";
                case TipoOperador.MenorOuIgual:
                    return " <= ";
                default:
                    return " = ";
            }
        }

        public Criterio<Entity> OrderBy(object parameterNameField)
        {
            StringOrderBy = " ORDER BY [" + NomeTabela + "]."+ parameterNameField.GetType().GetProperties()[0].Name;
            return this;
        }
        public string GetStringCriterio()
        {
            return TiraParentes(StringWhere + StringOrderBy);
        }

    }

}
