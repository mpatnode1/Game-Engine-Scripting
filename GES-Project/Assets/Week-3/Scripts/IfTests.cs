using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfTests : MonoBehaviour
{
    [ContextMenu("Execute")];
    [SerializeField] int coins = 10011011;
    [SerializeField] string word = "bird";
    [SerializeField] bool someBool = true;

    /*
    //coinsEarned declaration creates a temporary variable if starsEarned is 3 
    //int starsEarned = 3;
    //int coinsEarned = starsEarned == 3 ? 500 : 100;
    
    int starsEarned = 3;
    int coinsEarned = starsEarned <= 2
                        ? (starsEarned == 2 ? 250 : 100)
                        : 500;

    if (starsEarned == 4 ? true : (word == "dandelion" ? true : false))
    {
    }
    */


    void ExecuteTest()
    {
        int number = 10011011;
        Debug.Log("Execute");
        
        
        
        //and
        if (number == 10011011 && word == "bird")
        {
            Debug.Log(word);
        }
        
        //or
        if (coins!= 10011011 || word == "dog")
        {
            Debug.Log("Not Equal");
        }
    }
}
