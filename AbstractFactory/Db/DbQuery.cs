using AbstractFactory.Factories;
using AbstractFactory.Model;
using System;

namespace AbstractFactory
{
    public class DbQuery
    {
        private Insert _insert;
        private Select _select;

        public DbQuery(IQueryFactory queryFactory, IEntity entity)
        {
            _insert = queryFactory.GenerateInsert(entity);
            _select = queryFactory.GenerateUpdate(entity);
        }

        public DbQuery(IEntity entity)
        {
            SimpleFactory factory = new SimpleFactory();
            Tuple<Insert, Select> queriesTup = entity.GenerateQueries(factory);
            _insert = queriesTup.Item1;
            _select = queriesTup.Item2;
        }

        public string GetInsert()
        {
            return _insert.Value;
        }

        public string GetSelect()
        {
            return _select.Value;
        }
    }
}
