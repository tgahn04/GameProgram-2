
using UnityEngine;

public class T : MonoBehaviour
{
    [SerializeField] bool state;

    public bool Property
    {
        get { return state; }
    }

    private static T instance;

    public static T Instance
    {
        get 
        {
            if (instance == null)
            {
                instance = FindObjectOfType<T>();
            }

            if (instance == null)
            {
                GameObject clone = new GameObject(nameof(T));
                instance = clone.AddComponent<T>();

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
