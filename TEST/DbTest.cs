using Costum.DbEntity;

namespace TEST
{
    public class DbTest : DbCostum
    {
        public DbTest(InfoConnection info) : base(info)
        {

        }

        public TableSet<Pais> Pais { get; set; }
        public TableSet<Entidade> Entidade { get; set; }
        protected override void SetEntities()
        {
            base.SetEntities();

            AddSet<Pais>();
            AddSet<Entidade>();

        }
    }
}
