using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ds.test.impl
{
    internal class AdditionPlugin : PluginBase
    {
        public override string PluginName => "Сложение";
        public override string Version => "1.0";
        public override object GetImage() => null;
        public override string Description => "Плагин для сложения операций.";

        public override int Run(int input1, int input2)
        {
            return input1 + input2;
        }
    }
}
