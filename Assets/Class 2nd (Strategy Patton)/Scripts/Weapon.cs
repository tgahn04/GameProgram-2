using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    protected Animator animator;

    protected virtual void Awake()
    {
        animator = GetComponent<Animator>();
    }
    public abstract void Attack();
}
