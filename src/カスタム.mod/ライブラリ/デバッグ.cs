using System.Diagnostics;

namespace 将星録;

public static partial class カスタム
{
    [Conditional("TRACE")]
    public static void デバッグ出力(object value)
    {
        Trace.WriteLine(value);
    }

    [Conditional("TRACE")]
    public static void デバッグ出力(string message)
    {
        Trace.WriteLine(message);
    }

}