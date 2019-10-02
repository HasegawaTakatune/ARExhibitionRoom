using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// ヘッドライトの制御
/// </summary>
public class Headlight : MonoBehaviour
{
    /// <summary>
    /// ヘッドライト
    /// </summary>
    [SerializeField] private Light[] headlight = new Light[2];

    /// <summary>
    /// ライトのOnOff
    /// </summary>
    private bool Switch = false;

    /// <summary>
    /// 初期化
    /// </summary>
    private void Start()
    {
        GameObject.Find("HeadlightButton").GetComponent<Button>().onClick.AddListener(SwitchLight);
    }

    /// <summary>
    /// デストラクタ
    /// </summary>
    private void OnDestroy()
    {
        GameObject.Find("HeadlightButton").GetComponent<Button>().onClick.RemoveListener(SwitchLight);
    }

    /// <summary>
    /// ライトのOnOff
    /// </summary>
    public void SwitchLight()
    {
        Switch = !Switch;
        for (int i = 0; i < headlight.Length; i++)
            headlight[i].enabled = Switch;
    }

}
