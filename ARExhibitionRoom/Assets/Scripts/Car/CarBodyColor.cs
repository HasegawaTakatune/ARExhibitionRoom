using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ボディカラーの設定をする
/// </summary>
public class CarBodyColor : MonoBehaviour
{
    /// <summary>
    /// レンダラー格納
    /// </summary>
    [SerializeField] private List<Renderer> renderer = new List<Renderer>();

    /// <summary>
    /// 色の設定
    /// </summary>
    /// <param name="color"></param>
    public void SetColor(Color color)
    {
        for (int i = 0; i < renderer.Count; i++)
            renderer[i].material.color = color;
    }
}
