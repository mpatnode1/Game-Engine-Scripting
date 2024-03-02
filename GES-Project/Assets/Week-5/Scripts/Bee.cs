using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System.Xml.Linq;

public class Bee : MonoBehaviour
{
    private BeeHive hiveLocation;
    //public Flower flower;
    bool holdingHoney = false;

    // Start is called before the first frame update
    void Start()
    {
        nextMove();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Init(BeeHive hive)
    {
        hiveLocation = hive;

    }

    void nextMove()
    {
        if (holdingHoney)
        {
            goToHive();
            holdingHoney = false;
        }
        else
        {
            CheckAnyFlower();
        }

    }

    void CheckAnyFlower()
    {
        Flower chosenFlower = FindFlower();

        transform.DOMove(chosenFlower.transform.position, 1f).OnComplete(() =>
        {
            //Take nectar from flower
            bool flowerHasNectar = chosenFlower.GetNectar();
            if (flowerHasNectar)
            {
                //If flower returned nectar then go back to the hive and give hive nectar
                holdingHoney = true;
                nextMove();
            }
            else
            {
                //If flower did not return nectar then go check another flower
                CheckAnyFlower();
            }
        }).SetEase(Ease.Linear);

    }

    void goToHive()
    {
        transform.DOMove(hiveLocation.transform.position, 1f).OnComplete(() =>
        {
            hiveLocation.GiveNectar();
            holdingHoney = false;
            nextMove();

        }).SetEase(Ease.Linear);
    }

    Flower FindFlower()
    {
        
        var flowersInGame = FindObjectsByType < Flower > (FindObjectsSortMode.None);
        
        Flower randomFlower = flowersInGame[Random.Range(0, flowersInGame.Length)];

        return randomFlower;
    }
}
