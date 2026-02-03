using UnityEngine;
using UnityEngine.UI;

public class Guide : MonoBehaviour
{
    [SerializeField] Quest quest;
    [SerializeField] Canvas questCanvas;

    private void Awake()
    {
        questCanvas = transform.GetChild(0).GetComponent<Canvas>();
    }

    public void Accept()
    {
        Quest_Manager.Instance.Accept(quest);

        questCanvas.gameObject.SetActive(false);
    }
}
