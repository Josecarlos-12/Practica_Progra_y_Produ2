using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class For : MonoBehaviour
{
    private string[] _itemNames = new string[5] { "Sword", "Rock", "Apple", "HealthPotion", "ManaPotion" };

    void Start()
    {
        for (int i = 0; i < _itemNames.Length; i++)
        {

            Debug.Log("Item " + i + " : " + _itemNames[i]);

        }
    }
}
