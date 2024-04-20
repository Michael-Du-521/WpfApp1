using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
{
    internal class Class1
    {
        int stationId;
        int dataBits;
        private int stopBit;

        int StopBit { get => stopBit; set => stopBit = value; }
        static bool isRunning;

        public static bool Start() { 
        if(true == isRunning) {

                return false;
            }
            try
            {
                isRunning = true;
                
            }
            catch (Exception)
            {

                throw;
            }
            return true;
           

        
        }
    }
}
