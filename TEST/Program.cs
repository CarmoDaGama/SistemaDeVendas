using Costum.DbEntity;
using Sistema.Domain.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace TEST
{
    class Program
    {
        static Entidade entity;
        static void Main(string[] args)
        {
            DbTest db = new DbTest(new InfoConnection() {
                ServerName = "localhost",
                DataBaseName = "BD_GANA",
                Porta =-1,
                Senha ="VisualBasic",
                Tipo = TipoBaseDados.MySql,
                Usuario = "root"
            });
            //entity = db.Initialize(entity);
            var criterio = CriterioBuilder.WhereDiferente<Entidade>(new { PaisId = 1}, TipoJionCriterio.AND, " ");
            List<Entidade> list = db.Set<Entidade>().GetAllFor(criterio);
            Console.Write("EntidadeId--Nome--Nacionalidade \n");
            list = db.Set<Entidade>().GetAllFor(criterio);
            Console.Write("====================================\n\n\n");
            foreach (var item in list)
            {
                Console.Write(item.EntidadeId + "--" + item.Nome + "--" + item.Pais.Descricao + "--\n");
            }
            Console.Read();
        }
    }
}
