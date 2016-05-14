using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



using UnityEngine;

namespace Decoupling_UnityLib.View
{
    class Logger
    {
        public static void Log(string message)
        {
            Debug.Log(message);
        }
    }
}
