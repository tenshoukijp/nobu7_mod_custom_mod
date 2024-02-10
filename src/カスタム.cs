using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 将星録;

using 引数型 = System.Collections.Generic.Dictionary<string, object>;
using 返値型 = System.Collections.Generic.Dictionary<string, object>;

public static class カスタム
{
    public static 返値型 onメインウィンドウ生成後(引数型 arg)
    {
        System.Diagnostics.Trace.WriteLine("onメインウィンドウ生成後");
        int ハンドル = (int)arg["ウィンドウハンドル"];
        System.Diagnostics.Trace.WriteLine(ハンドル);
        return null;
    }

    public static 返値型 on初期設定画面時(引数型 arg)
    {
        System.Diagnostics.Trace.WriteLine("on初期設定画面時");
        return null;
    }

    public static 返値型 onメインゲーム開始時(引数型 arg)
    {
        System.Diagnostics.Trace.WriteLine("onメインゲーム開始時");
        return null;
    }

    public static 返値型 on戦略画面大名ターン変更前(引数型 arg)
    {
        System.Diagnostics.Trace.WriteLine("on戦略画面大名ターン変更前");
        System.Diagnostics.Trace.WriteLine((int)arg["大名番号"]);
        return null;
    }


    public static 返値型 onメインウィンドウ破棄前(引数型 arg)
    {
        System.Diagnostics.Trace.WriteLine("onメインウィンドウ破棄前");
        return null;
    }

    public static 返値型 onフォント名要求時(引数型 arg)
    {
        System.Diagnostics.Trace.WriteLine("onフォント名要求時");
        返値型 ret = new();
        ret["フォント名"] = "ＭＳ ゴシック";
        return null;
    }

    public static 返値型 onムービーファイル名要求時(引数型 arg)
    {
        System.Diagnostics.Trace.WriteLine("onムービーファイル名要求時");
        System.Diagnostics.Trace.WriteLine("元ファイル名" + arg["ファイル名"]);
        返値型 ret = new();
        ret["ファイル名"] = @"OVERRIDE\MOVIE\CHRIST.AVI";
        return ret;
    }

    public static 返値型 on武将行動済時(引数型 arg)
    {
        System.Diagnostics.Trace.WriteLine("on武将行動済時");
        System.Diagnostics.Trace.WriteLine(arg["武将番号"]);
        返値型 ret = new();
        ret["行動済"] = 0;
        return null;
    }
}

