public class ATTACK : IStateavle
{
    public Character.StateType Type => Character.StateType.ATTACK;

    public void Enter(Character character)
    {
        character.TriggerAttack();
    }

    public void Update(Character character)
    {
    }

    public void Exit(Character character)
    {
    }
}