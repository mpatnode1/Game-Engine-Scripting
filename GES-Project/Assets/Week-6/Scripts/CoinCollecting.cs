using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Week11
{
    public class CoinCollecting : MonoBehaviour
    {
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
            PlayerStats.Instance.PlayerCoinCount += 1;
            gameObject.SetActive(false);
        }
    }
}
