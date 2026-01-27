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
        Debug.Log("Start 호출됨");
        ChangeState(idleState);
    }

    void Update()
    {
        currentState.Update(this);

        HandleInput();
    }

    private void ChangeState(IStateavle newState)
    {
         Debug.Log($"ChangeState 호출: {newState?.Type}");

        if (currentState == newState)
            return;

        currentState?.Exit(this);

        currentState = newState;

        currentState.Enter(this);
    }

    private void HandleInput()
    {
        Debug.Log($"현재 상태: {currentState.Type}");

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
        animator.SetBool("IsWalk", value);
    }

    public void TriggerAttack()
    {
        animator.SetTrigger("Attack");
    }

    public void OnAttackAnimationEnd()
    {
        ChangeState(idleState);
    }
}
