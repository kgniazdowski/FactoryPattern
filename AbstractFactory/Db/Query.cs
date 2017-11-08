
using AbstractFactory.Model;

namespace AbstractFactory.Db
{
    public abstract class Query
    {
        public string Value { get; set; }

        public abstract void PrepareQuery(IEntity entity);
    }
}
