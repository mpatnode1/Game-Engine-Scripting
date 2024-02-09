using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayCode : MonoBehaviour
{
    int[] array = new int[4];
    //alternative way to create array
    // int[] array = new int[]{1, 234, 33, 35};
    //OR OR you could make this public and do it in the inspector

    [ContextMenu("Execute")]
    void Execute()
    {

        array[0] = 2;
        array[21] = 21;

        //first element in array at 0
        Debug.Log(array[0]);

        //last element in array at zero
        Debug.Log(array[3]);

        //prints out same thing as line 21
        //array.length is the number of items in array (4)
        Debug.Log(array[array.Length - 1]);
        

    
    }
}
