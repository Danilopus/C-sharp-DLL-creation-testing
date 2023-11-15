using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ds.test.impl
{
    public class Plugins : IPluginFactory
    {
        public int PluginsCount { get; } = 2;
        public string[] GetPluginNames { get; } = { "Addition", "Multiply" };
        public IPlugin GetPlugin(string pluginName)
        {
            switch (pluginName) 
            {
                case "Addition": return new Addition();
                case "Multiply": return new Multiply();
                default:  throw new Exception("Cannot find plugin name");
            }
        }
    }


    public class Addition : IPlugin
    {
        public string PluginName { get; } = "Addition";
        public string Version { get; } = "1.0";
        public string Description { get; } = "input1 + input2";
        public int Run(int input1, int input2) { return input1+input2; }
    }
    public class Multiply : IPlugin
    {
        public string PluginName { get; } = "Multiply";
        public string Version { get; } = "1.0";
        public string Description { get; } = "input1 * input2";
        public int Run(int input1, int input2) { return input1 * input2; }
    }


}
