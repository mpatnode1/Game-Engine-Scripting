using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Week11
{
    public class Damage : MonoBehaviour
    {
        private bool OnTrigger = false;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        private void FixedUpdate()
        {
            if (OnTrigger)
            {
                PlayerStats.Instance.PlayerHealth -= 1;
            }

        }

        private void OnTriggerEnter(Collider other)
        {
            PlayerStats.Instance.PlayerHealth -= 1;
            OnTrigger = true;
            Debug.Log("milk");
        }

        private void OnTriggerExit(Collider other)
        {
            OnTrigger = false;
        }

    }
}
