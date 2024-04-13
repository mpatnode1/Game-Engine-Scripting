using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Week11
{
    public class HealthGUI : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            gameObject.GetComponent<TextMeshProUGUI>().text = "Health: " + PlayerStats.Instance.PlayerHealth;
        }
    }
}