using System.Runtime.CompilerServices;

namespace ScriptNgine
{
    public class ScriptNgineManager
    {
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        static extern public void RegisterClass(string namespase, string klass);

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        static extern public void RegisterEvent(string klass);
    }
}
