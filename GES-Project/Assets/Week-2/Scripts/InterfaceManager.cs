using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InterfaceManager : MonoBehaviour
{

    /* Function called before Start:
     * Notes
    void Awake()
    {
        Debug.Log("Awake");
    }
    
    void Start()
    {
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update");
    }

    //called when gameobject is enabled or disabled
    private void OnEnable()
    {
        Debug.Log("Enable");
    }

    private void OnDisable()
    {
        Debug.Log("Disable");
    }

    */

    public TextMeshProUGUI Label;
    public void PrintMessage(string msg)
    {
        Label.text = msg;  
        Debug.Log("I am printing.");

    }

    public void Add(int number)
    {
        Label.text = (number + 10).ToString();
    }

    
}
