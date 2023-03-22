using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class While : MonoBehaviour
{
    private bool condition;

    // Start is called before the first frame update
    void Start()
    {
         int i = 0;

        do
        {
            i++;
        }
        while (condition);

        Debug.Log(i);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
