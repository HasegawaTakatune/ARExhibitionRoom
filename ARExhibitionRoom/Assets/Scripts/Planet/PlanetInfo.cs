using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 惑星の情報
/// </summary>
public class PlanetInfo : MonoBehaviour
{
    /// <summary>
    /// パネル
    /// </summary>
    [SerializeField] private GameObject Panel;

    /// <summary>
    /// 情報
    /// </summary>
    [SerializeField] private Text Info;

    /// <summary>
    /// マスク
    /// </summary>
    [SerializeField] private LayerMask mask;

    private readonly Vector3 HIDE = new Vector3(540.0f, 0, 0);

    private readonly Vector3 DISPLAY = new Vector3(275.0f, 0, 0);

    private void Start()
    {
        Panel.transform.localPosition = HIDE;
    }

    /// <summary>
    /// メインループ
    /// </summary>
    private void Update()
    {
        ShowMessage();
    }

    /// <summary>
    /// メッセージ表
    /// </summary>
    /// <returns>true : 表示　 false : 未表示</returns>
    private void ShowMessage()
    {
        if (Input.touchCount < 1)
        {
            Panel.transform.localPosition = HIDE;
            return;
        }

        Touch touch = Input.GetTouch(0);

        if (touch.phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(touch.position);

            if (Physics.Raycast(ray, out RaycastHit hit, 10.0f, mask))
            {
                //Message message = hit.collider.GetComponent<Message>();
                //if (message != null)
                //    Info.text = message.GetMessage();
                Info.text = Message.GetMessage(hit.collider.name);
                Panel.transform.localPosition = DISPLAY;
            }
        }
        else if (touch.phase == TouchPhase.Canceled)
        {
            Panel.transform.localPosition = HIDE;
        }
    }
}
