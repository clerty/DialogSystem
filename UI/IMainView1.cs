﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    public interface IMainView : IView
    {
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}
