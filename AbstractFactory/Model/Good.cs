using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Factories;

namespace AbstractFactory.Model
{
    public class Good : IEntity
    {
        public string Name { get; set; }

        public Tuple<Insert, Select> GenerateQueries(SimpleFactory factory)
        {
            Insert insert = factory.GenerateGoodInsert(this);
            Select select = factory.GenerateGoodSelect(this);
            Tuple<Insert, Select> resultTup = new Tuple<Insert, Select>(insert, select);
            return resultTup;
        }
    }
}
