using System.Runtime.InteropServices;

namespace Bloxstrap
{
    internal static class NativeInjector
    {
        const string DLL = "injector.dll";

        [DllImport(DLL)] public static extern void InitializeInjector();
        [DllImport(DLL)] public static extern int ConnectToProcess(uint pid);
        [DllImport(DLL)] public static extern void DisconnectFromProcess();
        [DllImport(DLL)] public static extern int IsConnected();

        [DllImport(DLL, CharSet = CharSet.Ansi)]
        public static extern int SetFlagBool(uint pid, string name, int val);

        [DllImport(DLL, CharSet = CharSet.Ansi)]
        public static extern int SetFlagInt(uint pid, string name, int val);

        [DllImport(DLL, CharSet = CharSet.Ansi)]
        public static extern int SetFlagFloat(uint pid, string name, float val);

        [DllImport(DLL, CharSet = CharSet.Ansi)]
        public static extern int SetFlagString(uint pid, string name, string value);
    }
}