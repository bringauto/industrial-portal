﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artin.BringAuto.DAL
{
    public interface ISoftDelete
    {
        bool Deleted { get; set; }
    }
}
