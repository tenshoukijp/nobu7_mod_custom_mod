using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using 将星録;

namespace 将星録;

public static partial class カスタム {

    // 静的コンストラクタ
    static カスタム()
    {
        for (int ix = 0; ix < 将星録.最大数.家宝情報.配列数; ix++)
        {
            家宝情報配列.Add(new 家宝情報型(ix));
        }

        for (int ix = 0; ix < 将星録.最大数.官位情報.配列数; ix++)
        {
            官位情報配列.Add(new 官位情報型(ix));
        }

        for (int ix = 0; ix < 将星録.最大数.役職情報.配列数; ix++)
        {
            役職情報配列.Add(new 役職情報型(ix));
        }
    }

    public static 年月情報型 年月情報 = new();
    public static 相場情報型 相場情報 = new();
    public static List<家宝情報型> 家宝情報配列 = new();
    public static List<官位情報型> 官位情報配列 = new();
    public static List<役職情報型> 役職情報配列 = new();
}




