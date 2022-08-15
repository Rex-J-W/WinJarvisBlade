using Jarvis.API;
using Jarvis.API.Behaviors;
using System.Diagnostics;

namespace WinJarvisBlade.Blades
{
    public class TestBehavior : IStart
    {
        public bool Enabled { get; set; } = true;

        public int Priority => 100;

        public void Start()
        {
            Debug.WriteLine("test");
        }
    }
}
