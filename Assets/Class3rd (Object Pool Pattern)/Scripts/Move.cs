using UnityEngine;

public class Move : MonoBehaviour
{
    Transform portal;
    [SerializeField] float moveSpeed;
    [SerializeField] float arriveDistance;

    void Start()
    {
        GameObject PortalObject = GameObject.Find("Portal");

        if (PortalObject != null)
        {
            portal = PortalObject.transform;
        }
    }

    void Update()
    {
        if (portal == null)
            return;

        Vector3 direction = portal.position - transform.position;
        direction.y = 0f;

        transform.position += direction.normalized * moveSpeed * Time.deltaTime;

        if (direction.magnitude <= arriveDistance)
        {
            Object_Pool.Instance.ReturnObject(gameObject);
        }
    }
}
