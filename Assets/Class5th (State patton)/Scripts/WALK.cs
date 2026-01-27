public class WALK : IStateavle
{
    public Character.StateType Type => Character.StateType.WALK;

    public void Enter(Character character)
    {
        character.SetWalk(true);
    }

    public void Update(Character character)
    {
    }

    public void Exit(Character character)
    {
        character.SetWalk(false);
    }
}