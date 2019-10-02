using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// ドアの制御
/// </summary>
public class Door : MonoBehaviour
{
    /// <summary>
    /// ドア
    /// </summary>
    [SerializeField] private List<Animation> anims = new List<Animation>();

    /// <summary>
    /// ステータス
    /// </summary>
    private List<AnimationState> states = new List<AnimationState>();

    /// <summary>
    /// 名前
    /// </summary>
    [SerializeField] private List<string> names = new List<string>();

    /// <summary>
    /// スイッチ
    /// </summary>
    private bool Switch = true;

    /// <summary>
    /// 行動中かの判定
    /// </summary>
    private bool move = false;

    /// <summary>
    /// 初期化
    /// </summary>
    private void Start()
    {
        GameObject.Find("DoorButton").GetComponent<Button>().onClick.AddListener(SwitchDoor);

        // ステータス取得
        for (int i = 0; i < anims.Count; i++)
            states.Add(anims[i][names[i]]);
    }

    /// <summary>
    /// デストラクタ
    /// </summary>
    private void OnDestroy()
    {
        GameObject.Find("DoorButton").GetComponent<Button>().onClick.RemoveListener(SwitchDoor);
    }

    /// <summary>
    /// ドアの開閉
    /// </summary>
    public void SwitchDoor()
    {
        if (move) return;

        if (Switch)
            StartCoroutine(Open());
        else
            StartCoroutine(Close());
    }

    /// <summary>
    /// ドアを開く
    /// </summary>
    /// <returns></returns>
    private IEnumerator Open()
    {
        float timer = 0;
        float limit = states[0].length / 2;
        move = true;

        // ドアを開く
        for (int i = 0; i < anims.Count; i++)
        {
            states[i].speed = 1;
            anims[i].Play();
        }

        // ドアが開ききるまで待つ
        while (true)
        {
            yield return new WaitForSeconds(Time.deltaTime);
            timer += Time.deltaTime;
            if (timer > limit) break;
        }

        // 開ききったらアニメーションを止める
        for (int i = 0; i < states.Count; i++)
            states[i].speed = 0;

        Switch = !Switch;
        move = false;
    }

    /// <summary>
    /// ドアを閉じる
    /// </summary>
    /// <returns></returns>
    private IEnumerator Close()
    {
        move = true;

        // ドアを閉じる
        for (int i = 0; i < states.Count; i++)
            states[i].speed = -1;

        // ドアが閉じきるまで待つ
        while (true)
        {
            yield return new WaitForSeconds(Time.deltaTime);
            if (states[0].time <= 0) break;
        }

        // アニメーションを止める
        for (int i = 0; i < anims.Count; i++)
            anims[i].Stop();

        Switch = !Switch;
        move = false;
    }
}