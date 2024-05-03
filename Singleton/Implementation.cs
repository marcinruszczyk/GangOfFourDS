﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Logger
    {

        private static Logger? _instance;

        //Instance
        public static Logger Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Logger();
                }
                return _instance;
            }

        }

        protected Logger()
        {
        }

        public void Log(string message) 
        {
            Console.WriteLine($"Message to log: {message}");
        }



    }
}
