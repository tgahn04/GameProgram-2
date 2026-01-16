using UnityEngine;

public class Knife : Weapon
{
    public override void Attack()
    {
        animator.Play("Attack");
    }
}
