﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ControlsShorcutsCDRAddon.Models
{
    public class Shortcut
    {
        public string Name { get; set; }
        public string Guid { get; set; }
        public bool Control { get; set; }
        public bool Shift { get; set; }
        public bool Alt { get; set; }
        public string Key { get; set; }
    }
}
