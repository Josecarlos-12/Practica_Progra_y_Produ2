using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arreglo : MonoBehaviour
{
    // Start is called before the first frame update
    public float[] numbers;
    void Start()
    {
        foreach (int i in numbers)
        {
            print(i);
        }

        numbers=new float[10];

        numbers[1] = 1;
        numbers[2] = 2;
        numbers[3] = 3;
    }
}
