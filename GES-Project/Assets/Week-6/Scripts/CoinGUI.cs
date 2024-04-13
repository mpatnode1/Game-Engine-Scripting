using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Week11
{
    public class CoinGUI : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            gameObject.GetComponent<TextMeshProUGUI>().text = "Coins: " + PlayerStats.Instance.PlayerCoinCount;
        }

    }
}