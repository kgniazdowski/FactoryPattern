using AbstractFactory.Db;
using AbstractFactory.Model;

namespace AbstractFactory
{
    public class Insert : Query
    {
        public override void PrepareQuery(IEntity entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
