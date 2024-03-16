using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondDoorTrigger : MonoBehaviour
{

    private Animator doorAnim;
    private bool doorOpen = false;

    [SerializeField] GameObject DiamondDoor;
    [SerializeField] GameObject CorrectKey;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (CorrectKey.activeInHierarchy == false)
        {
            ToggleDoorState();
        }
    }

    public void ToggleDoorState()
    {
        doorAnim = DiamondDoor.GetComponent<Animator>();
        if (!doorOpen)
        {
            doorAnim.Play("OpenDoor");
        }
        else
        {
            doorAnim.Play("CloseDoor");
        }
        doorOpen = !doorOpen;
    }
}
