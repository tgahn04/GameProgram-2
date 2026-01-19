using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public  class Grenade : Weapon
{
    [SerializeField] Rigidbody rigidbody;
    [SerializeField] private Vector3 throwForce;
    private Vector3 startPosition;
    private Quaternion startRotation;

    protected override void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();

        startPosition = transform.position;
        startRotation = transform.rotation;

        rigidbody.isKinematic = true;
    }
     
    public override void Attack()
    {
        rigidbody.isKinematic = false;

        rigidbody.AddForce(throwForce, ForceMode.Impulse);
    }

    private void OnBecameInvisible()
    {
        ResetGrenade();
    }

    private void ResetGrenade()
    {
        rigidbody.linearVelocity = Vector3.zero;
        rigidbody.angularVelocity = Vector3.zero;
        rigidbody.isKinematic = true;

        transform.position = startPosition;
        transform.rotation = startRotation;
    }
}
