using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using 将星録;
using 将星録.野戦;

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