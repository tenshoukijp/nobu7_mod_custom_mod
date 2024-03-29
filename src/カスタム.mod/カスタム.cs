﻿global using System;
global using System.Collections.Generic;
global using System.IO;
global using System.Windows.Forms;
global using System.Text;
global using System.Text.RegularExpressions;

global using 将星録;

global using 引数型 = System.Collections.Generic.IReadOnlyDictionary<string, object>;
global using 返値型 = System.Collections.Generic.IDictionary<string, object>;
using System.Linq;

namespace 将星録;


public static partial class カスタム
{
    public static void onメインウィンドウ生成後(引数型 arg, 返値型 ret)
    {
        デバッグ出力("onメインウィンドウ生成後");
        int ハンドル = (int)arg["ウィンドウハンドル"];
        デバッグ出力(ハンドル);
    }
    private static int 項目番号その１ = 0;
    private static int 項目番号その２ = 0;
    public static void onメニュー追加要求時(引数型 arg, 返値型 ret)
    {
        デバッグ出力("onメニュー追加要求時");
        項目番号その１ = アプリケーション.メニュー.項目追加("私のカスタムメニュー (&W)");
        項目番号その２ = アプリケーション.メニュー.項目追加("私のカスタムメニュー２");
        _ = アプリケーション.メニュー.項目追加("---");
    }

    public static void onメニュー項目実行時(引数型 arg, 返値型 ret)
    {
        var b = 家宝情報配列.Count;
        デバッグ出力("onメニュー項目実行時");
        デバッグ出力(arg["項目番号"]);
        int 押された項目番号 = (int)arg["項目番号"];
        if (項目番号その１ == 押された項目番号)
        {
            デバッグ出力("私のカスタムメニューが押されました");
        }
    }

    public static void on初期設定画面時(引数型 arg, 返値型 ret)
    {
        デバッグ出力("on初期設定画面時");
    }

    public static void onメインゲーム開始時(引数型 arg, 返値型 ret)
    {
        int a = 将星録.列挙.家宝.配列.一重切園城寺;

        デバッグ出力("onメインゲーム開始時");
    }

    public static void on相場要求時(引数型 arg, 返値型 ret)
    {
        デバッグ出力("★年は" + 年月情報.年);
        デバッグ出力("★月は" + 年月情報.月);
        
        デバッグ出力((int)arg["兵糧"]);
        デバッグ出力((int)arg["軍馬"]);
        デバッグ出力((int)arg["鉄砲"]);
        // ret["兵糧"] = 30;
        // ret["軍馬"] = 40;
        // 相場情報.鉄砲 = 200;
        // ret["鉄砲"] = 198;
    }

    public static void on戦略画面大名ターン変更前(引数型 arg, 返値型 ret)
    {
        デバッグ出力("on戦略画面大名ターン変更前");
        デバッグ出力((int)arg["大名番号"]);
        デバッグ出力((int)arg["武将番号"]);
        int iDIX = (int)arg["大名番号"];
        if (0 <= iDIX && iDIX < 大名情報配列.Count)
        {
            int iBIX = 大名情報配列[iDIX].大名武将配列IX;
            if (0 <= iBIX && iBIX < 武将情報配列.Count)
            {
                デバッグ出力("武将名" + 武将情報配列[iBIX].姓名);
            }
        }
    }

    public static void on戦略画面プレイヤー大名ターン変更前(引数型 arg, 返値型 ret)
    {
        デバッグ出力("on戦略画面プレイヤー大名ターン変更前");
        デバッグ出力((int)arg["大名番号"]);
        デバッグ出力((int)arg["武将番号"]);
    }


    public static void onメインウィンドウ破棄前(引数型 arg, 返値型 ret)
    {
        デバッグ出力("onメインウィンドウ破棄前");
    }

    public static void onフォント要求時(引数型 arg, 返値型 ret)
    {
        デバッグ出力("onフォント要求時");
        // ret["フォント名"] = "ＭＳ ゴシック";
    }

    public static void onファイル要求時(引数型 arg, 返値型 ret)
    {
        /*
        デバッグ出力("onファイル要求時");
        デバッグ出力("元ファイル名" + arg["ファイル名"]);
        ret["ファイル名"] = @"OVERRIDE\あいうえお.dat";
        return ret;
        */
    }

    public static void onムービー要求時(引数型 arg, 返値型 ret)
    {
        デバッグ出力("onムービーファイル要求時");
        デバッグ出力("元ファイル名" + arg["ファイル名"]);
        // ret["ファイル名"] = @"OVERRIDE\MOVIE\CHRIST.AVI";
    }

    public static void on音楽要求時(引数型 arg, 返値型 ret)
    {
        デバッグ出力("on音楽要求時");
        デバッグ出力("元ファイル名" + arg["ファイル名"]);
        // ret["ファイル名"] = @"BGM\02.WAV";
    }

    public static void on効果音要求時(引数型 arg, 返値型 ret)
    {
        デバッグ出力("on音楽要求時");
        デバッグ出力("元ファイル名" + arg["ファイル名"]);

        // ret["ファイル名"] = @"Taiko.wav";
    }

    public static void on家宝画像要求時(引数型 arg, 返値型 ret)
    {
        デバッグ出力("on家宝画像要求時");
        デバッグ出力("家宝番号" + arg["家宝番号"]);
        // ret["ファイル名"] = @"C:\usr\steam\steamapps\common\Nobunaga7WPK\OVERRIDE\ITEMDATA\ΚΗΘΛΙΜ.bmp";
    }

    public static void on顔画像要求時(引数型 arg, 返値型 ret)
    {
        デバッグ出力("on顔画像要求時");
        デバッグ出力("顔番号" + arg["顔番号"]);
        // ret["ファイル名"] = @"C:\usr\steam\steamapps\common\Nobunaga7WPK\OVERRIDE\KAODATA\0000_B.bmp";
    }

    public static void on家紋画像要求時(引数型 arg, 返値型 ret)
    {
        デバッグ出力("on家紋画像要求時");
        デバッグ出力("家紋番号" + arg["家紋番号"]);
        ret["ファイル名"] = @"C:\usr\steam\steamapps\common\Nobunaga7WPK\OVERRIDE\KAMON\my001.bmp";
    }


    public static void on武将メッセージ要求時(引数型 arg, 返値型 ret)
    {
        デバッグ出力("on武将メッセージ要求時");
        デバッグ出力((int)arg["武将番号１人目"]);
        デバッグ出力((int)arg["武将番号２人目"]);
        デバッグ出力((int)arg["武将番号３人目"]);
        デバッグ出力((int)arg["武将番号４人目"]);
        デバッグ出力((String)arg["メッセージ"]);
        // ret["メッセージ"] = "あいうえお";
    }

    public static void onテキスト描画時(引数型 arg, 返値型 ret)
    {
        // デバッグ出力("onテキスト描画時");
        // デバッグ出力(arg["テキスト"]);
    }

    public static void on武将列伝要求時(引数型 arg, 返値型 ret)
    {
        デバッグ出力(arg["武将番号"]);

        // ret["ラベル"] = "織田信長 ｱｲｳｴお";
        // ret["詳細"] = "あいうえお\nあいうえお\nあいうえお\nあいうえお\n";
    }

    public static void on家宝列伝要求時(引数型 arg, 返値型 ret)
    {
        デバッグ出力(arg["家宝番号"]);

        //  ret["ラベル"] = "家宝？ ﾖﾐｶﾞﾅ";
        // ret["詳細"] = "あいうえお\nあいうえお\nあいうえお\nあいうえお\n";
    }

    public static void on城列伝要求時(引数型 arg, 返値型 ret)
    {
        デバッグ出力(arg["城番号"]);

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
        デバッグ出力("on武将行動済時");
        デバッグ出力(arg["武将番号"]);
        // ret["行動済"] = 0;
    }

    public static void on野戦開始時(引数型 arg, 返値型 ret)
    {
        デバッグ出力("on野戦開始時");
        デバッグ出力("攻武" + arg["攻撃武将番号"]);
        デバッグ出力("攻ユ" + arg["攻撃ユニット番号"]);
        デバッグ出力("防武" + arg["防御武将番号"]);
        デバッグ出力("防ユ" + arg["防御ユニット番号"]);
    }

    public static void on野戦残りターン変更時(引数型 arg, 返値型 ret)
    {
        デバッグ出力("on野戦残りターン変更時");
        デバッグ出力("残りターン" + arg["残りターン"]);
    }

    public static void on野戦部隊行動前(引数型 arg, 返値型 ret)
    {
        デバッグ出力("on野戦部隊行動時");
        デバッグ出力("残りターン" + arg["残りターン"]);
        デバッグ出力("攻撃武将番号" + arg["攻撃武将番号"]);
        デバッグ出力("攻撃部隊番号" + arg["攻撃部隊番号"]);
        デバッグ出力("防御武将番号" + arg["防御武将番号"]);
    }

    public static void on野戦終了時(引数型 arg, 返値型 ret)
    {
        デバッグ出力("on野戦終了時");
    }

    public static void on籠城戦開始時(引数型 arg, 返値型 ret)
    {
        デバッグ出力("on籠城戦開始時");
        デバッグ出力("城" + arg["城番号"]);
        int iCastleID = (int)arg["城番号"];
        デバッグ出力("城名" + 城情報配列[iCastleID].城名);

        デバッグ出力("攻大" + arg["攻撃大名番号"]);
        int iAttackDaimyoID = (int)arg["攻撃大名番号"];
        int iAttackDaimyoBushouID = 大名情報配列[iAttackDaimyoID].大名武将配列IX;
        デバッグ出力("攻撃大名名" + 武将情報配列[iAttackDaimyoBushouID].姓名);

        デバッグ出力("防大" + arg["防御大名番号"]);
        int iDefentDaimyoID = (int)arg["防御大名番号"];
        int iDefendDaimyoBushouID = 大名情報配列[iDefentDaimyoID].大名武将配列IX;
        デバッグ出力("防御大名名" + 武将情報配列[iDefendDaimyoBushouID].姓名);
    }

    public static void on籠城戦残りターン変更時(引数型 arg, 返値型 ret)
    {
        デバッグ出力("on野戦残りターン変更時");
        デバッグ出力("残りターン" + arg["残りターン"]);
    }

    public static void on籠城戦攻撃部隊更新後(引数型 arg, 返値型 ret)
    {
        デバッグ出力("on籠城戦攻撃部隊更新後");
        デバッグ出力("残りターン" + arg["残りターン"]);
    }

    public static void on籠城戦防御部隊更新後(引数型 arg, 返値型 ret)
    {
        デバッグ出力("on籠城戦防御部隊更新後");
        デバッグ出力("残りターン" + arg["残りターン"]);
    }

    public static void on籠城戦ダメージ決定時(引数型 arg, 返値型 ret)
    {
        デバッグ出力("on籠城戦ダメージ決定前");
        デバッグ出力(arg["門防御度"]);
        ret["門防御度"] = 3;
    }
    
    public static void on籠城戦終了時(引数型 arg, 返値型 ret)
    {
        デバッグ出力("on籠城戦終了時");
    }

}

