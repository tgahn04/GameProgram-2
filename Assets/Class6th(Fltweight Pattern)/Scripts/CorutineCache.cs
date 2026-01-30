using System.Collections.Generic;
using UnityEngine;

public class CorutineCache
{
    private static Dictionary<float, WaitForSeconds> dictionary = new Dictionary<float, WaitForSeconds>();
   
    public static WaitForSeconds GetCachedWait(float time)
    {
        if (dictionary.ContainsKey(time))
        {
            return dictionary[time];
        }

        else
        {
            WaitForSeconds waitForSeconds = null;

            if(dictionary.TryGetValue(time, out waitForSeconds) == false)
            {
                dictionary.Add(time, new WaitForSeconds(time));

                waitForSeconds = dictionary[time];
            }

            return waitForSeconds;
        }
    }

}
