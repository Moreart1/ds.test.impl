using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ds.test.impl
{
    public static class Plugins
    {
        private static List<IPlugin> pluginList;

        //Конструктор
        static Plugins()
        {
            pluginList = new List<IPlugin>
            {
                // Примеры реализаций плагинов
                new AdditionPlugin(),
                new MultiplicationPlugin()
            };
        }

        public static int PluginsCount => pluginList.Count;

        /// <summary>
        /// Получить массив плагинов
        /// </summary>
        /// <returns>Массив плагинов</returns>
        public static string[] GetPluginNames()
        {
            List<string> pluginNames = new();
            foreach (var plugin in pluginList)
            {
                pluginNames.Add(plugin.PluginName);
            }
            return pluginNames.ToArray();
        }

        /// <summary>
        /// Получить плагин
        /// </summary>
        /// <param name="pluginName">Имя плагина</param>
        /// <returns>Плагин</returns>
        public static IPlugin GetPlugin(string pluginName) => pluginList.Find(plugin => plugin.PluginName == pluginName);
    }
}
