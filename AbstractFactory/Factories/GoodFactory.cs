using AbstractFactory.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class GoodFactory : IQueryFactory
    {
        public Insert GenerateInsert(IEntity entity)
        {
            var query = new GoodInsert();
            query.Value = string.Format("INSERT INTO Good (Name) VALUES ('{0}');", (entity as Good).Name);
            return query;
        }

        public Select GenerateUpdate(IEntity entity)
        {
            var query = new GoodSelect();
            query.Value = string.Format("SELECT * FROM Good WHERE Name = '{0}';", (entity as Good).Name);
            return query;
        }
    }
}
