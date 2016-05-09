﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Models
{
    public abstract class InheritDb
    {
        public DateTime Created { get; set; }
        public DateTime? LastModified { get; set; }

        public bool IsRemoved { get; set; }

        protected InheritDb()
        {
            Created = DateTime.Now;
        }
    }

}
