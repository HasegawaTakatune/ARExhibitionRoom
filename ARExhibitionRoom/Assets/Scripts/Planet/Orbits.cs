using UnityEngine;

/// <summary>
/// Orbits
/// </summary>
public class Orbits : MonoBehaviour
{
    /// <summary>
    /// 初期化
    /// </summary>
    void Start()
    {
        GameObject.Find("PlanetManager").GetComponent<PlanetInfo>().enabled = true;
    }
}
