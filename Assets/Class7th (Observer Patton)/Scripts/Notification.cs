using UnityEngine;
using UnityEngine.UI;

public class Notification : MonoBehaviour
{
    [SerializeField] Sprite sprite;
    [SerializeField] Canvas canvas;
    [SerializeField] Image questimage;

    private void Awake()
    {
        canvas = transform.GetChild(0).GetComponent<Canvas>();
        questimage = transform.GetChild(0).GetComponent<Image>();
    }

    private void OnEnable()
    {
        Quest_Manager.OnQuestCompleted += Show;
    }

    private void OnDisable()
    {
        Quest_Manager.OnQuestCompleted -= Show;
    }

    public void Show(Quest quest)
    {
        if (quest.Completed)
        {
            canvas.gameObject.SetActive(true);

            questimage.sprite = sprite;

            Debug.Log("Quest_Name : " + quest.Title + "Clear");
        }
    }

}
