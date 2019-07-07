﻿using System;
using System.Collections.Generic;

namespace LMS.Models.LMSModels
{
    public partial class Submissions
    {
        public uint? Score { get; set; }
        public string Contents { get; set; }
        public DateTime Time { get; set; }
        public string UId { get; set; }
        public uint AId { get; set; }

        public virtual Assignments A { get; set; }
        public virtual Students U { get; set; }
    }
}