using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

/// <summary>
/// 車の回転制御
/// </summary>
public class CarRotation : MonoBehaviour
{
    /// <summary>
    /// Transform
    /// </summary>
    [SerializeField] private new Transform transform;

    /// <summary>
    /// 速度
    /// </summary>
    [SerializeField] private float speed = 1.0f;

    /// <summary>
    /// 左回転
    /// </summary>
    private bool Left = false;

    /// <summary>
    /// 右回転
    /// </summary>
    private bool Right = false;

    /// <summary>
    /// 初期化
    /// </summary>
    void Start()
    {
        // 左回転ボタンDownイベント設定
        EventTrigger.Entry entry = new EventTrigger.Entry();
        entry.eventID = EventTriggerType.PointerDown;
        entry.callback.AddListener((x) => StartLeftRotation());
        GameObject.Find("LeftRotationButton").GetComponent<EventTrigger>().triggers.Add(entry);

        // 左回転ボタンUpイベント設定
        entry = new EventTrigger.Entry();
        entry.eventID = EventTriggerType.PointerUp;
        entry.callback.AddListener((x) => StopLeftRotation());
        GameObject.Find("LeftRotationButton").GetComponent<EventTrigger>().triggers.Add(entry);

        // 右回転ボタンUpイベント設定
        entry = new EventTrigger.Entry();
        entry.eventID = EventTriggerType.PointerDown;
        entry.callback.AddListener((x) => StartRightRotation());
        GameObject.Find("RightRotationButton").GetComponent<EventTrigger>().triggers.Add(entry);

        // 右回転ボタンUpイベント設定
        entry = new EventTrigger.Entry();
        entry.eventID = EventTriggerType.PointerUp;
        entry.callback.AddListener((x) => StopRightRotation());
        GameObject.Find("RightRotationButton").GetComponent<EventTrigger>().triggers.Add(entry);
    }

    /// <summary>
    /// 左回転
    /// </summary>
    public void StartLeftRotation()
    {
        Left = true;
        StartCoroutine(LeftRotation());
    }

    /// <summary>
    /// 左回転
    /// </summary>
    public void StopLeftRotation()
    {
        Left = false;
    }

    /// <summary>
    /// 左回転
    /// </summary>
    public IEnumerator LeftRotation()
    {
        while (Left)
        {
            yield return new WaitForSeconds(Time.deltaTime);
            transform.RotateAround(transform.position, transform.up, speed * Time.deltaTime);
        }
    }

    /// <summary>
    /// 右回転
    /// </summary>
    public void StartRightRotation()
    {
        Right = true;
        StartCoroutine(RightRotation());
    }

    /// <summary>
    /// 右回転
    /// </summary>
    public void StopRightRotation()
    {
        Right = false;
    }

    /// <summary>
    /// 右回転
    /// </summary>
    public IEnumerator RightRotation()
    {
        while (Right)
        {
            yield return new WaitForSeconds(Time.deltaTime);
            transform.RotateAround(transform.position, transform.up, -speed * Time.deltaTime);
        }
    }
}