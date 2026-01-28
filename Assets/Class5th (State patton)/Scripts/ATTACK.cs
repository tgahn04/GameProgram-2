public class ATTACK : IStateavle
{
    public Character.StateType Type => Character.StateType.ATTACK;

    public void Enter(Character character)
    {
        character.TriggerAttack();
    }

    public void Update(Character character)
    {
        if (character.AttackFinished())
        {
            character.ChangeToIdle();
        }
    }

    public void Exit(Character character)
    {
    }
}