using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    public GameObject Coin1;
    public GameObject Coin2;
    public GameObject Coin3;

    public GameObject collectedCoin1;
    public GameObject collectedCoin2;
    public GameObject collectedCoin3;

    public GameObject escape;
    public GameObject successScreen;

    public bool hasCoin1BeenCollected;
    public bool hasCoin2BeenCollected;
    public bool hasCoin3BeenCollected;


    void Start()
    {
        hasCoin1BeenCollected = false;
        hasCoin2BeenCollected = false;
        hasCoin3BeenCollected = false;
    }

    
    void Update()
    {
        if (hasCoin1BeenCollected == true && hasCoin2BeenCollected == true && hasCoin3BeenCollected == true)
        {
            escape.SetActive(true);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == ("Coin1"))
        {
            hasCoin1BeenCollected = true;
            Destroy(Coin1);
            collectedCoin1.SetActive(true);
        }

        if (collision.gameObject.tag == ("Coin2"))
        {
            hasCoin2BeenCollected = true;
            Destroy(Coin2);
            collectedCoin2.SetActive(true);
        }

        if (collision.gameObject.tag == ("Coin3"))
        {
            hasCoin3BeenCollected = true;
            Destroy(Coin3);
            collectedCoin3.SetActive(true);
        }

        if (collision.gameObject.tag == ("Escape"))
        {
            successScreen.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }


}
