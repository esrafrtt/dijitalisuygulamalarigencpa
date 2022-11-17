﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.EntitiesBase;

namespace Entities.Concrete
{
    public class City : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
