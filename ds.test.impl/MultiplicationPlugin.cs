using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ds.test.impl
{
    internal class MultiplicationPlugin : PluginBase
    {
        public override string PluginName => "Умножение";
        public override string Version => "1.0";
        public override object GetImage() => null;
        public override string Description => "Плагин для умножения операций.";

        /// <summary>
        /// Метод умножения двух чисел
        /// </summary>
        /// <param name="input1">Первое число</param>
        /// <param name="input2">Второе число</param>
        /// <returns>Умножение двух чисел</returns>
        public override int Run(int input1, int input2) => input1 * input2;
    }
}
