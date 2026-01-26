using UnityEngine;
using System.Collections.Generic;

public class Bundle : MonoBehaviour, IRewardable
{
    [SerializeField] private List<IRewardable> list = new List<IRewardable>();

    public void Add(IRewardable reward)
    {
        list.Add(reward);
    }

    public void Receive()
    {
        foreach (IRewardable reward in list)
        {
            reward.Receive();
        }
    }
}
