﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pledgewise.Common.Model.Entity
{
    public class PostEntityDTO : BasePostEntity
    {
        public string CreatedByUserId { get; set; }
    }
}