using UnityEngine;
using System.Collections.Generic;

public class Weapon_Manager : MonoBehaviour
{
    [SerializeField] List<Weapon> weapons;
    [SerializeField] int count = 0;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            weapons[count].Attack();
        }

        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            Swap();
        }
    }

    void Swap()
    {
        weapons[count].gameObject.SetActive(false);

        count = (count + 1) % weapons.Count;

        weapons[count].gameObject.SetActive(true);
    }

}
