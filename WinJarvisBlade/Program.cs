using Jarvis.API;

namespace WinJarvisBlade
{
    internal static class Program
    {
        public static void Main()
        {
            JAPIService winBlade = new JAPIService("win_blade", false);
            winBlade.Start();
        }
    }
}