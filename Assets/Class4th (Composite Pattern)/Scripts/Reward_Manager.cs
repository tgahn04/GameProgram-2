using Unity.VisualScripting;
using UnityEngine;

public class Reward_Manager : MonoBehaviour
{
    [SerializeField] int CreateCount;
    [SerializeField] Bundle bundle;
    [SerializeField] Reward reward;
    [SerializeField] GameObject RewardList;

    private void Awake()
    {
        CreateCount = Random.Range(1, 5);
    }

    void Start()
    {
        Create();
    }

    public void Create()
    {
        for (int i = 0; i < CreateCount; i++)
        {
            bundle.Add(Instantiate(reward));
        }
    }

    void Accept()
    {

    }
}
