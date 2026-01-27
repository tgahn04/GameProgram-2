public interface IStateavle
{
    Character.StateType Type { get; }

    void Enter(Character character);

    void Update(Character character);

    void Exit(Character character);
}