using UnityEngine;

public class Kiwi : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float range;
    [SerializeField] float T;

    [SerializeField] Quaternion quaternion;

    private void Start()
    {
        quaternion = transform.rotation;
    }

    private void Update()
    {
        if (!global::T.Instance.Property)
            return;

        T += Time.deltaTime * speed;

        float rotation = Mathf.PingPong(T, range);
        transform.rotation = quaternion * Quaternion.Euler(rotation, 0f, 0f);
    }
}
