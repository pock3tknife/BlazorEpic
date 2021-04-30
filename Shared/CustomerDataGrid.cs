﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorEpic.Shared
{
    [Serializable]
    public class CustomerDataGrid
    {
        public string id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string zip { get; set; }
        public bool vip { get; set; }
    }
}
