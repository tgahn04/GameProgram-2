using UnityEngine;
using UnityEngine.UI;

public class Handler : MonoBehaviour
{
    [SerializeField] Button pauseBotton;

    private void Awake()
    {
        pauseBotton = GetComponent<Button>();

        pauseBotton.onClick.AddListener(T.Instance.Pause);
    }

}
