public class IDLE : IStateavle
{
    public Character.StateType Type => Character.StateType.IDLE;

    public void Enter(Character character)
    {
        character.SetWalk(false);
    }

    public void Update(Character character)
    {
    }

    public void Exit(Character character)
    {
    }
}