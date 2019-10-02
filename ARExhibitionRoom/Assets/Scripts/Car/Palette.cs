using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// パレット
/// </summary>
public class Palette : MonoBehaviour
{
    /// <summary>
    /// 色
    /// </summary>
    private Color _color;
    /// <summary>
    /// 色
    /// </summary>
    public Color color { get { return _color; } }

    /// <summary>
    /// 初期化
    /// </summary>
    private void Start()
    {
        _color = GetComponent<Image>().color;
        GetComponent<Button>().onClick.AddListener(SelectedColor);
    }

    /// <summary>
    /// デストラクタ
    /// </summary>
    private void OnDestroy() { Destroy(this); }

    /// <summary>
    /// デリゲート
    /// </summary>
    /// <param name="clr">色</param>
    public delegate void Delegate(Color clr);

    /// <summary>
    /// 色変更
    /// </summary>
    private Delegate _ChangeColor;

    /// <summary>
    /// 色変更
    /// </summary>
    public Delegate ChangeColor { set { _ChangeColor = value; } }

    /// <summary>
    /// 色選択ボタンイベント
    /// </summary>
    public void SelectedColor() { _ChangeColor(_color); }
}