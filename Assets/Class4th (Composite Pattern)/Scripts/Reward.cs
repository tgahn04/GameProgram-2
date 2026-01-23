using UnityEngine;
using UnityEngine.UI;

public class Reward : MonoBehaviour
{
    [SerializeField] Item item;
    [SerializeField] Item[] items;

    [SerializeField] Data[] dataList;

    [SerializeField] Sprite sprite;
    [SerializeField] Image image;

    [SerializeField] int random;

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
