using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;


namespace 将星録;

public static partial class カスタム {

    // 静的コンストラクタ
    static カスタム()
    {
        List<大名情報型> _大名情報型 = new();
        for (int ix = 0; ix < 将星録.最大数.大名情報.配列数; ix++)
        {
            _大名情報型.Add(new 大名情報型(ix));
        }
        大名情報配列 = _大名情報型.AsReadOnly(); // 要素の追加や削除は認めない

        List<城情報型> _城情報型 = new();
        for (int ix = 0; ix < 将星録.最大数.城情報.配列数; ix++)
        {
            _城情報型.Add(new 城情報型(ix));
        }
        城情報配列 = _城情報型.AsReadOnly(); // 要素の追加や削除は認めない

        List<家宝情報型> _家宝情報配列 = new();
        for (int ix = 0; ix < 将星録.最大数.家宝情報.配列数; ix++)
        {
            _家宝情報配列.Add(new 家宝情報型(ix));
        }
        家宝情報配列 = _家宝情報配列.AsReadOnly(); // 要素の追加や削除は認めない

        List<官位情報型> _官位情報型 = new();
        for (int ix = 0; ix < 将星録.最大数.官位情報.配列数; ix++)
        {
            _官位情報型.Add(new 官位情報型(ix));
        }
        官位情報配列 = _官位情報型.AsReadOnly(); // 要素の追加や削除は認めない

        List<役職情報型> _役職情報型 = new();
        for (int ix = 0; ix < 将星録.最大数.役職情報.配列数; ix++)
        {
            _役職情報型.Add(new 役職情報型(ix));
        }
        役職情報配列 = _役職情報型.AsReadOnly(); // 要素の追加や削除は認めない

        List<将星録.野戦.攻撃部隊情報型> _攻撃部隊情報 = new();
        for (int ix = 0; ix < 将星録.最大数.ユニット情報.軍勢部隊数; ix++)
        {
            _攻撃部隊情報.Add(new 将星録.野戦.攻撃部隊情報型(ix));
        }
        野戦.攻撃部隊情報 = _攻撃部隊情報.AsReadOnly(); // 要素の追加や削除は認めない

        List<将星録.野戦.防御部隊情報型> _防御部隊情報 = new();
        for (int ix = 0; ix < 将星録.最大数.ユニット情報.軍勢部隊数; ix++)
        {
            _防御部隊情報.Add(new 将星録.野戦.防御部隊情報型(ix));
        }
        野戦.防御部隊情報 = _防御部隊情報.AsReadOnly(); // 要素の追加や削除は認めない

    }

    public static 年月情報型 年月情報 = new();
    public static 相場情報型 相場情報 = new();

    public static ReadOnlyCollection<大名情報型> 大名情報配列;
    public static ReadOnlyCollection<城情報型> 城情報配列;
    public static ReadOnlyCollection<家宝情報型> 家宝情報配列;
    public static ReadOnlyCollection<官位情報型> 官位情報配列;
    public static ReadOnlyCollection<役職情報型> 役職情報配列;

    public static 大名関係情報型 大名関係情報 = new();

    public static class 野戦
    {
        public static 将星録.野戦.ターン情報型 ターン情報 = new();
        public static ReadOnlyCollection<将星録.野戦.攻撃部隊情報型> 攻撃部隊情報;
        public static ReadOnlyCollection<将星録.野戦.防御部隊情報型> 防御部隊情報;
    }

}




