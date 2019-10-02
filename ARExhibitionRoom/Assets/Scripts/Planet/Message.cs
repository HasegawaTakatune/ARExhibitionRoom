using UnityEngine;

/// <summary>
/// 惑星からのメッセージ
/// </summary>
public class Message : MonoBehaviour
{
    /// <summary>
    /// 惑星の情報
    /// </summary>
    private static readonly string[] message = {
        "水星（すいせい、英：Mercury）\n太陽からの距離： 57,910,000 km公転周期： 88日(恒星日)\n一日の長さ： 58日 15時間 30分\n質量： 3.285 × 10^23 kg (0.055 M⊕)\n重力： 3.7 m/s²\n自転周期： 58日 15.5088時間",
        "金星（きんせい、英語: Venus ）\n太陽からの距離： 108,200,000 km\n公転周期： 225日\n一日の長さ： 116日 18時間 0分\n質量： 4.867 × 10^24 kg (0.815 M⊕)\n重力： 8.87 m/s²\n自転周期： 243.0187 日（逆行）",
        "地球（ちきゅう、英: Earth）\n太陽からの距離： 149,600,000 km\n公転周期 ： 365.256363004 日（恒星年）\n一日の長さ： 365日 24時間 0分\n質量： 5.972×10^24 kg\n自転周期    23時間56分4.0905秒（恒星日）",
        "火星（かせい、英語: Mars）\n平均気温： −43℃; （−130℃ + 0℃にも満たない）\n自転周期： 24.6229 時間（1.026 日）\n公転周期 ： 686.98 日（1.880866 年）\n表面重力： 3.71 m/s2\n地球との相対質量： 0.10745\n平均公転半径： 227,936,640 km",
        "木星（もくせい、英語: Jupiter）\n質量： 1.898 × 10^27 kg\n重力： 24.79 m/s²\n太陽からの距離： 778,500,000 km\n自転周期： 9時間55.5分; （0.4135 日）\n公転周期： 11.86155年\n",
        "土星（どせい、英語: Saturn）\n太陽からの距離： 1.434 × 10^9 km\n質量： 5.683 × 10^26 kg(95.16 M⊕)\n公転周期： 29歳\n一日の長さ： 0日 10時間 42分",
        "天王星（てんのうせい、英語: Uranus）\n太陽からの距離： 2.871 × 10^9 km\n質量： 8.681 × 10^25 kg(14.54 M⊕)\n公転周期： 84歳\n自転周期： 17時間14分（0.7183 日）（逆行）",
        "海王星（かいおうせい、英語: Neptune）\n太陽からの距離： 4.495 × 10^9 km\n公転周期： 165歳\n質量： 1.024 × 10^26 kg(17.15 M⊕)\n自転周期： 0.671 日; （16時間6分36秒）",
        "太陽（たいよう、英: Sun）\n表面温度： 5,778 K\n表面積： 6.07877×1012 km2\n距離： 1.4710×1011 m 〜 1.5210×1011 m; (0.9833 au 〜 1.0167 au)\n中心温度： 1.57×107 K\nコロナの温度： 5×106 K\n相対表面重力： 27.9 G"
    };

    /// <summary>
    /// 惑星の情報取得
    /// </summary>
    /// <param name="name">惑星名</param>
    /// <returns></returns>
    public static string GetMessage(string name)
    {
        switch (name)
        {
            case "mercury": return message[0];
            case "venus": return message[1];
            case "earth": return message[2];
            case "mars": return message[3];
            case "jupiter": return message[4];
            case "saturn": return message[5];
            case "uranus": return message[6];
            case "neptune": return message[7];
            case "sun": return message[8];
            default: return "";
        }
    }
}
