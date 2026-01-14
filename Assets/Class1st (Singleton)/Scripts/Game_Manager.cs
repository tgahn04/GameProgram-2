using UnityEngine;

public class Game_Manager : MonoBehaviour
{
    [SerializeField] bool state;

    public bool Property
    {
        get { return state; }
    }

    private static Game_Manager instance;

    public static Game_Manager Instance
    {
        get 
        {
            if (instance == null)
            {
                instance = FindObjectOfType<Game_Manager>();
            }

            return instance; 
        }
    }

    public void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }

        instance = this;
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
