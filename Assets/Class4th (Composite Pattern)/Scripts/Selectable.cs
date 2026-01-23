using UnityEngine;

public class Selectable : MonoBehaviour
{
    [SerializeField] RectTransform rectTransform;
    [SerializeField] Vector3 vector3;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    public void Select()
    {
        rectTransform.localScale = vector3;
    }

    public void Deselect()
    {
        rectTransform.localScale = Vector3.one;
    }
}
