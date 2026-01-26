using UnityEngine;
using UnityEngine.UI;

public class Reward : MonoBehaviour, IRewardable
{
    [SerializeField] Item item;
    [SerializeField] Item[] items;

    [SerializeField] Item[] dataList;

    [SerializeField] Sprite sprite;
    [SerializeField] Image image;

    [SerializeField] int random;

    public void Receive()
    {
        Debug.Log(gameObject.name);
    }

    private void Awake()
    {
        image = GetComponent<Image>();
    }

    void Start()
    {
        random = Random.Range(0, dataList.Length);

        gameObject.name = dataList[random].Name;

        image.sprite = dataList[random].GetSprite;
    }
}
