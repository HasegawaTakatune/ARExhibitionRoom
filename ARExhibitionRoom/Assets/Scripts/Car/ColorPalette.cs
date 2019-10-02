using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// カラーパレット
/// </summary>
public class ColorPalette : MonoBehaviour
{
    /// <summary>
    /// パレット
    /// </summary>
    [SerializeField] private List<GameObject> palette = new List<GameObject>();

    /// <summary>
    /// コンテンツ
    /// </summary>
    [SerializeField] private GameObject content;

    /// <summary>
    /// ボディカラー
    /// </summary>
    [SerializeField] private CarBodyColor _bodyColor;
    /// <summary>
    /// ボディカラー
    /// </summary>
    public CarBodyColor BodyColor { set { _bodyColor = value; } }

    /// <summary>
    /// 初期化
    /// </summary>
    private void Start()
    {
        // コンテンツ取得
        content = GameObject.Find("Content");

        // 設置座標を設定
        Vector2 position = new Vector3(-200, 0);

        for (int i = 0; i < palette.Count; i++)
        {
            // 生成
            GameObject obj = Instantiate(palette[i], Vector3.zero, Quaternion.identity, content.transform);

            // パレットを配置する
            RectTransform rect = obj.GetComponent<RectTransform>();
            rect.anchoredPosition = position;
            position.x += 80;

            // パレットにボタンクリックイベントを設定する（デリゲートに代入する）
            Palette pltt = obj.GetComponent<Palette>();
            pltt.ChangeColor = SetColor;
        }
    }

    /// <summary>
    /// 色をセット
    /// </summary>
    /// <param name="color">色</param>
    public void SetColor(Color color)
    {
        if (_bodyColor != null)
            _bodyColor.SetColor(color);
    }
}
