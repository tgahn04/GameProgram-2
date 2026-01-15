
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

            if (instance == null)
            {
                GameObject clone = new GameObject(nameof(Game_Manager));
                instance = clone.AddComponent<Game_Manager>();

                Debug.Log("Game_Manager 생성됨");
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

        // instance = this;
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
