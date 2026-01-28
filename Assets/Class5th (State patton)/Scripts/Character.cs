using UnityEngine;

public class Character : MonoBehaviour
{
    public enum StateType
    {
        IDLE,
        WALK,
        ATTACK
    }

    [SerializeField] Animator animator;

    [SerializeField] IStateavle idleState;
    [SerializeField] IStateavle walkState;
    [SerializeField] IStateavle attackState;

    private IStateavle currentState;

    void Awake()
    {
        idleState = new IDLE();
        walkState = new WALK();
        attackState = new ATTACK();
    }

    void Start()
    {
        ChangeState(idleState);
    }

    void Update()
    {
        currentState.Update(this);

        HandleInput();
    }

    public void ChangeState(IStateavle newState)
    {
        if (currentState == newState)
            return;

        if(currentState != null)
        {
            currentState.Exit(this);
        }

        currentState = newState;

        currentState.Enter(this);
    }

    private void HandleInput()
    {
        switch (currentState.Type)
        {
            case StateType.IDLE:
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    ChangeState(attackState);
                }
                else if (Input.GetKey(KeyCode.W))
                {
                    ChangeState(walkState);
                }
                break;

            case StateType.WALK:
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    ChangeState(attackState);
                }
                else if (!Input.GetKey(KeyCode.W))
                {
                    ChangeState(idleState);
                }
                break;

            case StateType.ATTACK:
                break;
        }
    }

    public void SetWalk(bool value)
    {
        animator.SetBool("Walk", value);
    }

    public void TriggerAttack()
    {
        animator.SetTrigger("Attack");
    }

    public bool AttackFinished()
    {
        AnimatorStateInfo info = animator.GetCurrentAnimatorStateInfo(0);
   
        return info.IsName("Attack") == false;
    }
   
    public void ChangeToIdle()
    {
        ChangeState(idleState);
    }
}
