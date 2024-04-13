using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Week11
{
    public class WinTrigger : MonoBehaviour
    {
        //[SerializeField] GameObject WinScreen;

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
            //WinScreen.SetActive(true);
            GameManager.instance.WinGameOverEvent.Invoke();

        }
    }
}
