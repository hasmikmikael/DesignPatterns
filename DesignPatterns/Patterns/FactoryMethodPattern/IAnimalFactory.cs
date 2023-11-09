﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public abstract class IAnimalFactory
    {
        public abstract IAnimal CreateAnimal();
    }
}
