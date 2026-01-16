using UnityEngine;

public  class Rifle : Weapon
{
    [SerializeField] GameObject Bullet;
    [SerializeField] Transform rocation;

    public override void Attack()
    {
        Quaternion rot = rocation.rotation * Quaternion.Euler(90f, 0f, 0f);

        Instantiate(Bullet, rocation.position, rot);
    }

}
