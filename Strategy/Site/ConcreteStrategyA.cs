﻿using Strategy.Site.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Site
{
    // Concrete Strategies implement the algorithm while following the base
    // Strategy interface. The interface makes them interchangeable in the
    // Context.
    class ConcreteStrategyA : IStrategy
    {
        public object DoAlgorithm(object data)
        {
            var list = data as List<string>;
            list.Sort();

            return list;
        }
    }
}