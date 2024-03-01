using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 将星録;

using 引数型 = System.Collections.Generic.IReadOnlyDictionary<string, object>;
using 返値型 = System.Collections.Generic.IDictionary<string, object>;

public static partial class カスタム
{
    public static void onメインウィンドウ生成後(引数型 arg, 返値型 ret)
    {
        System.Diagnostics.Trace.WriteLine("onメインウィンドウ生成後");
        int ハンドル = (int)arg["ウィンドウハンドル"];
        System.Diagnostics.Trace.WriteLine(ハンドル);
    }
    private static int 項目番号その１ = 0;
    private static int 項目番号その２ = 0;
    public static void onメニュー追加要求時(引数型 arg, 返値型 ret)
    {
        System.Diagnostics.Trace.WriteLine("onメニュー追加要求時");
        項目番号その１ = アプリケーション.メニュー.項目追加("私のカスタムメニュー (&W)");
        項目番号その２ = アプリケーション.メニュー.項目追加("私のカスタムメニュー２");
        _ = アプリケーション.メニュー.項目追加("---");
    }

    public static void onメニュー項目実行時(引数型 arg, 返値型 ret)
    {
        家宝情報配列.Count();
        System.Diagnostics.Trace.WriteLine("onメニュー項目実行時");
        System.Diagnostics.Trace.WriteLine(arg["項目番号"]);
        int 押された項目番号 = (int)arg["項目番号"];
        if (項目番号その１ == 押された項目番号)
        {
            System.Diagnostics.Trace.WriteLine("私のカスタムメニューが押されました");
        }
    }

    public static void on初期設定画面時(引数型 arg, 返値型 ret)
    {
        System.Diagnostics.Trace.WriteLine("on初期設定画面時");
    }

    public static void onメインゲーム開始時(引数型 arg, 返値型 ret)
    {
        int a = 将星録.列挙.家宝.配列.一重切園城寺;

        System.Diagnostics.Trace.WriteLine(arg["家宝番号"]);
        System.Diagnostics.Trace.WriteLine("onメインゲーム開始時");
    }

    public static void on相場要求時(引数型 arg, 返値型 ret)
    {
        System.Diagnostics.Trace.WriteLine("★年は" + 年月情報.年);
        System.Diagnostics.Trace.WriteLine("★月は" + 年月情報.月);
        
        System.Diagnostics.Trace.WriteLine((int)arg["兵糧"]);
        System.Diagnostics.Trace.WriteLine((int)arg["軍馬"]);
        System.Diagnostics.Trace.WriteLine((int)arg["鉄砲"]);
        ret["兵糧"] = 30;
        ret["軍馬"] = 40;
        // 相場情報.鉄砲 = 200;
        ret["鉄砲"] = 198;
        大名関係情報.同盟残[20, 30] = 20;
    }

    public static void on戦略画面大名ターン変更前(引数型 arg, 返値型 ret)
    {
        System.Diagnostics.Trace.WriteLine("on戦略画面大名ターン変更前");
        System.Diagnostics.Trace.WriteLine((int)arg["大名番号"]);
        System.Diagnostics.Trace.WriteLine((int)arg["武将番号"]);
    }

    public static void on戦略画面プレイヤー大名ターン変更前(引数型 arg, 返値型 ret)
    {
        System.Diagnostics.Trace.WriteLine("on戦略画面プレイヤー大名ターン変更前");
        System.Diagnostics.Trace.WriteLine((int)arg["大名番号"]);
        System.Diagnostics.Trace.WriteLine((int)arg["武将番号"]);
    }


    public static void onメインウィンドウ破棄前(引数型 arg, 返値型 ret)
    {
        System.Diagnostics.Trace.WriteLine("onメインウィンドウ破棄前");
    }

    public static void onフォント要求時(引数型 arg, 返値型 ret)
    {
        System.Diagnostics.Trace.WriteLine("onフォント要求時");
        // ret["フォント名"] = "ＭＳ ゴシック";
    }

    public static void onファイル要求時(引数型 arg, 返値型 ret)
    {
        /*
        System.Diagnostics.Trace.WriteLine("onファイル要求時");
        System.Diagnostics.Trace.WriteLine("元ファイル名" + arg["ファイル名"]);
        ret["ファイル名"] = @"OVERRIDE\あいうえお.dat";
        return ret;
        */
    }

    public static void onムービー要求時(引数型 arg, 返値型 ret)
    {
        System.Diagnostics.Trace.WriteLine("onムービーファイル要求時");
        System.Diagnostics.Trace.WriteLine("元ファイル名" + arg["ファイル名"]);
        // ret["ファイル名"] = @"OVERRIDE\MOVIE\CHRIST.AVI";
    }

    public static void on音楽要求時(引数型 arg, 返値型 ret)
    {
        System.Diagnostics.Trace.WriteLine("on音楽要求時");
        System.Diagnostics.Trace.WriteLine("元ファイル名" + arg["ファイル名"]);
        // ret["ファイル名"] = @"BGM\02.WAV";
    }

    public static void on効果音要求時(引数型 arg, 返値型 ret)
    {
        System.Diagnostics.Trace.WriteLine("on音楽要求時");
        System.Diagnostics.Trace.WriteLine("元ファイル名" + arg["ファイル名"]);
        // ret["ファイル名"] = @"Taiko.wav";
    }


    public static void on武将メッセージ要求時(引数型 arg, 返値型 ret)
    {
        System.Diagnostics.Trace.WriteLine("on武将メッセージ要求時");
        System.Diagnostics.Trace.WriteLine((int)arg["武将番号１人目"]);
        System.Diagnostics.Trace.WriteLine((int)arg["武将番号２人目"]);
        System.Diagnostics.Trace.WriteLine((int)arg["武将番号３人目"]);
        System.Diagnostics.Trace.WriteLine((int)arg["武将番号４人目"]);
        System.Diagnostics.Trace.WriteLine((String)arg["メッセージ"]);
        // ret["メッセージ"] = "あいうえお";
    }

    public static void on武将列伝要求時(引数型 arg, 返値型 ret)
    {
        System.Diagnostics.Trace.WriteLine(arg["武将番号"]);

        // ret["ラベル"] = "織田信長 ｱｲｳｴお";
        // ret["詳細"] = "あいうえお\nあいうえお\nあいうえお\nあいうえお\n";
    }

    public static void on家宝列伝要求時(引数型 arg, 返値型 ret)
    {
        System.Diagnostics.Trace.WriteLine(arg["家宝番号"]);

        //  ret["ラベル"] = "家宝？ ﾖﾐｶﾞﾅ";
        // ret["詳細"] = "あいうえお\nあいうえお\nあいうえお\nあいうえお\n";
    }

    public static void on城列伝要求時(引数型 arg, 返値型 ret)
    {
        System.Diagnostics.Trace.WriteLine(arg["城番号"]);

        // ret["ラベル"] = "城？ ﾖﾐｶﾞﾅ";
        // ret["詳細"] = "あいうえお\nあいうえお\nあいうえお\nあいうえお\n";
    }



    public static void on家宝種類名要求時(引数型 arg, 返値型 ret)
    {
        家宝情報配列[3].家宝名 = "あいう";

        // ret["種類名"] = "ぴよ🎵よああ";
    }

    public static void on武将行動済時(引数型 arg, 返値型 ret)
    {
        System.Diagnostics.Trace.WriteLine("on武将行動済時");
        System.Diagnostics.Trace.WriteLine(arg["武将番号"]);
        // ret["行動済"] = 0;
    }

    public static void on野戦開始時(引数型 arg, 返値型 ret)
    {
        System.Diagnostics.Trace.WriteLine("on野戦開始時");
        System.Diagnostics.Trace.WriteLine("攻武" + arg["攻撃武将番号"]);
        System.Diagnostics.Trace.WriteLine("攻ユ" + arg["攻撃ユニット番号"]);
        System.Diagnostics.Trace.WriteLine("防武" + arg["防御武将番号"]);
        System.Diagnostics.Trace.WriteLine("防ユ" + arg["防御ユニット番号"]);
    }
    public static void on野戦残りターン変更時(引数型 arg, 返値型 ret)
    {
        System.Diagnostics.Trace.WriteLine("on野戦残りターン変更時");
        System.Diagnostics.Trace.WriteLine("攻武" + arg["攻撃武将番号"]);
        System.Diagnostics.Trace.WriteLine("攻ユ" + arg["攻撃ユニット番号"]);
        System.Diagnostics.Trace.WriteLine("防武" + arg["防御武将番号"]);
        System.Diagnostics.Trace.WriteLine("防ユ" + arg["防御ユニット番号"]);
        System.Diagnostics.Trace.WriteLine("残りターン" + arg["残りターン"]);
    }

    public static void on野戦部隊行動前(引数型 arg, 返値型 ret)
    {
        System.Diagnostics.Trace.WriteLine("on野戦部隊行動時");
        System.Diagnostics.Trace.WriteLine("残りターン" + arg["残りターン"]);
        System.Diagnostics.Trace.WriteLine("攻撃武将番号" + arg["攻撃武将番号"]);
        System.Diagnostics.Trace.WriteLine("攻撃部隊番号" + arg["攻撃部隊番号"]);
        System.Diagnostics.Trace.WriteLine("防御武将番号" + arg["防御武将番号"]);
    }

    public static void on野戦終了時(引数型 arg, 返値型 ret)
    {
        System.Diagnostics.Trace.WriteLine("on野戦終了時");
    }

    public static void on籠城戦終了時(引数型 arg, 返値型 ret)
    {
        System.Diagnostics.Trace.WriteLine("on籠城戦終了時");
    }

}

