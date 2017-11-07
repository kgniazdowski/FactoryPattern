using AbstractFactory.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public interface IQueryFactory
    {
        Insert GenerateInsert(IEntity entity);
        Select GenerateUpdate(IEntity entity);
    }
}
