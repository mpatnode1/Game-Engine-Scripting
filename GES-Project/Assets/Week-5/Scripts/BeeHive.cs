using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BeeHive : MonoBehaviour
{
    //this should ONLY count down if it has nectar
    float hiveHoneyProduction = 5f;

    int beeStartingCount = 2;

    public GameObject beePrefab;
   
    [SerializeField] int currentNectarCount = 1;
    [SerializeField] int currentHoneyCount = 0;

    [SerializeField] float timer = 0.0f;

    Bee bee;

    public TextMeshProUGUI honeyCountText;

    // Start is called before the first frame update
    void Start()
    {
        
            for (int i = 0; i < beeStartingCount; i++)
            {
                var newBee = Instantiate(beePrefab, this.transform.position, Quaternion.identity);
                bee = newBee.GetComponent<Bee>();

                newBee.transform.parent = this.transform.parent;

                bee.Init(this);
            }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        honeyCreator();
    }

    /// <summary>
    /// creates honey if nectar count is greater than 1 and timer is at 5
    /// </summary>
    void honeyCreator()
    {
        if (currentNectarCount >= 1)
        {
            timer += 1;
            if (timer > 250)
            {
                currentNectarCount -= 1;
                currentHoneyCount += 1;
                honeyCountText.text = "Honey Total:" + currentHoneyCount.ToString(); 
                timer = 0;
            }

        }
    }

    public void GiveNectar()
    {
        currentNectarCount += 1;
    }
}
