using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using 将星録;

namespace 将星録;

public static partial class カスタム {

    // 静的コンストラクタ
    static カスタム()
    {
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
    }

    public static 年月情報型 年月情報 = new();
    public static 相場情報型 相場情報 = new();
    public static ReadOnlyCollection<家宝情報型> 家宝情報配列;
    public static ReadOnlyCollection<官位情報型> 官位情報配列;
    public static ReadOnlyCollection<役職情報型> 役職情報配列;
}




