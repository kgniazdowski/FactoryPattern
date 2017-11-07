﻿using AbstractFactory.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Model
{
    public interface IEntity
    {
        Tuple<Insert, Select> GenerateQueries(SimpleFactory factory);
    }
}
