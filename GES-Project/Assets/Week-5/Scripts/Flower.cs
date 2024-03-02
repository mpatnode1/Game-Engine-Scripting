using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Flower : MonoBehaviour
{

    [SerializeField] Color NectarReadyColor;
    [SerializeField] Color NectorNotReadyColor;

    public float NectarRateProduced = 1f;
    public float NectarRateTime = 250f;

    bool FlowerHasNectar = true;

    Image flowerSprite;

    public void Start()
    {
        flowerSprite = GetComponent<Image>();
    }

    void FixedUpdate()
    {
        if (NectarRateTime >= 250)
        //checks if enough time has passed for nectar to regenerate
        {
            FlowerHasNectar = true;
            flowerSprite.color = NectarReadyColor;

        }
        else
        //otherwise it continues counting nectar
        {
            NectarRateTime += 1;

        }
    }

    public bool GetNectar()
    {
        if (FlowerHasNectar)
        {
            NectarRateTime = 0f;
            flowerSprite.color = NectorNotReadyColor;
            FlowerHasNectar = false;
            return true;
        }
        else
        {
            return false;
        }
    }
}
