using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// シーン移動
/// </summary>
public class ChangeScene : MonoBehaviour
{
    /// <summary>
    /// 次のシーンに移動
    /// </summary>
    public void NextScene()
    {
        if (SceneManager.GetActiveScene().name == "PlanetExhibition")
            SceneManager.LoadScene("CarExhibition");
        else
            SceneManager.LoadScene("PlanetExhibition");
    }
}
