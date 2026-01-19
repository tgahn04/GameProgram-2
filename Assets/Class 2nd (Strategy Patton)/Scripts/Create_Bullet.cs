using UnityEngine;

public class Create_Bullet : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    [SerializeField] float duration;
    [SerializeField] Vector3 direction;

    void Start()
    {
        Destroy(gameObject, duration);
    }

    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);


    }
}
