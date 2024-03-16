using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int PlayerHealth = 20;
    public int PlayerCoinCount = 0;
    private static PlayerStats instance;

    [SerializeField] GameObject DiedText;

    public static PlayerStats Instance
    {
        get { return instance; }   
    }

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerHealth == 0)
        {
           // gameObject.GetComponent<PlayerControls>().Disable();
            DiedText.SetActive(true);
        }
    }
}
