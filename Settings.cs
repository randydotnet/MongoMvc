﻿using System;
using MongoDB.Driver;

namespace MongoMvc
{
    public class Settings
    {
        public string Database { get; set; }
        public string MongoConnection { get; set; }
    }
}