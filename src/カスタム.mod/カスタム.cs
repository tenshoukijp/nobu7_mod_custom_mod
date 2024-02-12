using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 将星録;

using 引数型 = System.Collections.Generic.Dictionary<string, object>;
using 返値型 = System.Collections.Generic.Dictionary<string, object>;

public static partial class カスタム
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
        System.Diagnostics.Trace.WriteLine(arg["家宝番号"]);
        System.Diagnostics.Trace.WriteLine("onメインゲーム開始時");
        return null;
    }

    public static 返値型 on相場要求時(引数型 arg)
    {
        System.Diagnostics.Trace.WriteLine((int)arg["相場兵糧"]);
        System.Diagnostics.Trace.WriteLine((int)arg["相場軍馬"]);
        System.Diagnostics.Trace.WriteLine((int)arg["相場鉄砲"]);
        返値型 ret = new();
        ret["相場兵糧"] = 30;
        ret["相場軍馬"] = 40;
        // ret["相場鉄砲"] = 60;
        return ret;
    }

    public static 返値型 on戦略画面大名ターン変更前(引数型 arg)
    {
        System.Diagnostics.Trace.WriteLine("on戦略画面大名ターン変更前");
        System.Diagnostics.Trace.WriteLine((int)arg["大名番号"]);
        System.Diagnostics.Trace.WriteLine((int)arg["武将番号"]);
        return null;
    }

    public static 返値型 on戦略画面プレイヤー大名ターン変更前(引数型 arg)
    {
        System.Diagnostics.Trace.WriteLine("on戦略画面プレイヤー大名ターン変更前");
        System.Diagnostics.Trace.WriteLine((int)arg["大名番号"]);
        System.Diagnostics.Trace.WriteLine((int)arg["武将番号"]);
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

    public static 返値型 on武将メッセージ要求時(引数型 arg)
    {
        System.Diagnostics.Trace.WriteLine("on武将メッセージ要求時");
        System.Diagnostics.Trace.WriteLine((int)arg["武将番号１人目"]);
        System.Diagnostics.Trace.WriteLine((int)arg["武将番号２人目"]);
        System.Diagnostics.Trace.WriteLine((int)arg["武将番号３人目"]);
        System.Diagnostics.Trace.WriteLine((int)arg["武将番号４人目"]);
        System.Diagnostics.Trace.WriteLine((String)arg["メッセージ"]);
        返値型 ret = new();
        // ret["メッセージ"] = "あいうえお";
        return null;
    }

    public static 返値型 on武将列伝要求時(引数型 arg)
    {
        System.Diagnostics.Trace.WriteLine(arg["武将番号"]);

        返値型 ret = new();
        ret["ラベル"] = "織田信長 ｱｲｳｴお";
        ret["詳細"] = "あいうえお\nあいうえお\nあいうえお\nあいうえお\n";
        return null;
    }

    public static 返値型 on家宝列伝要求時(引数型 arg)
    {
        System.Diagnostics.Trace.WriteLine(arg["家宝番号"]);

        返値型 ret = new();
        ret["ラベル"] = "家宝？ ﾖﾐｶﾞﾅ";
        ret["詳細"] = "あいうえお\nあいうえお\nあいうえお\nあいうえお\n";
        return null;
    }

    public static 返値型 on家宝種類名要求時(引数型 arg)
    {
        家宝情報配列[3].家宝名 = "あいう";

        返値型 ret = new();
        ret["種類名"] = "ぴよ🎵よああ";
        return null;
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

