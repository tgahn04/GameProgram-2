using UnityEngine;

public class Notification : MonoBehaviour
{
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
        Debug.Log("Quest_Name : " + quest.Title + "Clear");
    }

}
