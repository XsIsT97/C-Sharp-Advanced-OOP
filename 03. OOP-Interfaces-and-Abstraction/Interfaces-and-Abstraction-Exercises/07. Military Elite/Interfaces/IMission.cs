﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite.Interfaces
{
    public interface IMission
    {
        public string CodeName { get; set; }
        public Status Status { get; set; }
        void CompleteMission(string codeName);

    }
}
