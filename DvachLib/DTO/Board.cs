﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace DvachLib
{
    public class Thread
    {
        public string comment { get; set; }
        public int lasthit { get; set; }
        public int num { get; set; }
        public int posts_coun { get; set; }
        public double score { get; set; }
        public string subject { get; set; }
        public int timestamp { get; set; }
        public int views { get; set; }
    }

    public class Board
    {
        public string board { get; set; }
        public Thread[] threads { get; set; }
    }
}
