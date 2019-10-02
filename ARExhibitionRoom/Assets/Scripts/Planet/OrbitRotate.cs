using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 惑星を回転させる
/// </summary>
public class OrbitRotate : MonoBehaviour
{
    /// <summary>
    /// ボタンコンポーネント
    /// </summary>
    [SerializeField] private Image image;

    /// <summary>
    /// 一時停止イメージ
    /// </summary>
    [SerializeField] private Sprite StopImage;

    /// <summary>
    /// 再生イメージ
    /// </summary>
    [SerializeField] private Sprite PlayImage;

    /// <summary>
    /// ストップ
    /// </summary>
    private const short STOP = 0;

    /// <summary>
    /// 再生
    /// </summary>
    private const short PLAY = 1;

    /// <summary>
    /// モード
    /// </summary>
    private short mode;

    /// <summary>
    /// Transform格納
    /// </summary>
    private Transform[] trans = new Transform[9];

    /// <summary>
    /// 速度
    /// </summary>
    private float[] speed = new float[] { 90, 80, 70, 60, 50, 40, 30, 20 };

    /// <summary>
    /// 長さ
    /// </summary>
    private int length;

    /// <summary>
    /// 初期化
    /// </summary>
    void Start()
    {
        mode = PLAY;

        length = trans.Length;

        // transformの取得
        for (int i = 0; i < length; i++)
            trans[i] = GameObject.Find("orbit_" + (i + 1).ToString()).transform;
    }

    /// <summary>
    /// メインループ
    /// </summary>
    void Update()
    {
        // 惑星を回転させる
        if (mode == PLAY)
            for (int i = 0; i < length; i++)
                trans[i].RotateAround(trans[i].position, trans[i].forward, Time.deltaTime * speed[i]);
    }

    /// <summary>
    /// 状態を切り替える
    /// </summary>
    public void ChangeMode()
    {
        switch (mode)
        {
            case STOP: mode = PLAY; image.sprite = PlayImage; break;
            case PLAY: mode = STOP; image.sprite = StopImage; break;
        }
    }
}
