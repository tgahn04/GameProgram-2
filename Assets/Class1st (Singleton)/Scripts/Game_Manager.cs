using UnityEngine;

public class Game_Manager : MonoBehaviour
{
    [SerializeField] bool state;

    public static Game_Manager instance;

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void Start()
    {
        state = true;
    }

    public void Pause()
    {
        state = false;
    }
}
