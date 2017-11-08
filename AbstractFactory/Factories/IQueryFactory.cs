using AbstractFactory.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    interface IQueryFactory
    {
        Query PrepareQuery();
    }
}
