using UnityEngine;

public class Performance_Manager : MonoBehaviour
{
    [SerializeField] string[] questTitle;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Quest_Manager.Instance.Complete(questTitle[Random.Range(0, questTitle.Length)]);
        }
    }
}
