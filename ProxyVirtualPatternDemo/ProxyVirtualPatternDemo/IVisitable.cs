﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyVirtualPatternDemo
{
    interface IVisitable
    {
        void acceptAttack(IVisitor visitor);
    }
}
