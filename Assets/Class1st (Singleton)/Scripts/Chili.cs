using UnityEngine;

public class Chili : MonoBehaviour
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
        T += Time.deltaTime * speed;

        float rotation = Mathf.PingPong(T, range);
        transform.rotation = quaternion * Quaternion.Euler(0f, 0f, rotation);
    }

}
