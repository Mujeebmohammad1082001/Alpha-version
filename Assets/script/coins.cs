using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class coins : MonoBehaviour
{
    public AudioClip coinSound;
    public AudioClip crashSound;

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision) 
    {

        if(collision.gameObject.tag == "Player")
        {
            AudioSource.PlayClipAtPoint(coinSound, transform.position);
            Destroy(gameObject);

            GameHandler.numberofCoins++;

        }

    
    }
}
