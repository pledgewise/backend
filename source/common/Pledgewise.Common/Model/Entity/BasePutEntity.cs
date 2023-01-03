﻿using Pledgewise.Common.Model.Entity.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pledgewise.Common.Model.Entity
{
    public class BasePutEntity : BaseEntity
    {
        public long Id { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public EntityTypeEnum? Type { get; set; }
    }
}