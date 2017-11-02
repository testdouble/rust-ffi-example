using System;
using System.Runtime.InteropServices;
using System.Text;

public class FFI
{
    private static IntPtr _baton;

    [DllImport("libffi_example")]
    private static extern bool connect_to_server(out IntPtr baton, byte[] url);
    public static bool connectToServer(string url)
    {
        return connect_to_server(out _baton, Encoding.UTF8.GetBytes(url));
    }

    [DllImport("libffi_example")]
    private static extern void disconnect_from_server(out IntPtr baton);
    public static void disconnectFromServer()
    {
        disconnect_from_server(out _baton);
    }

    [DllImport("libffi_example")]
    private static extern void send_ding(IntPtr baton);
    public static void sendDing()
    {
        send_ding(_baton);
    }
}
