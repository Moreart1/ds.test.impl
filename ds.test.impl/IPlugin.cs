using static System.Net.Mime.MediaTypeNames;

namespace ds.test.impl
{
    public interface IPlugin
    {
        string PluginName { get; }
        string Version { get; }
        object GetImage();
        string Description { get; }
        int Run(int input1, int input2);
    }
}
