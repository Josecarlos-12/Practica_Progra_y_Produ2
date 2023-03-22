using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ie : MonoBehaviour
{
    public int myNumber = 10;

    void Start()
    {
        if (myNumber == 10)
        {
            print("myNumber is equal to 10");
        }
        else if (myNumber == 15)
        {
            print("myNumber is equal to 15");
        }
        else
        {
            print("myNumber is not equal to 10");
        }
    }
}


