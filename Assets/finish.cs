using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finish : MonoBehaviour
{
    public GameObject win_menu;


    private void OnCollisionEnter(Collision collision) 
    {

        if(collision.gameObject.tag == "Player")
        {
            //gameObject.SetActive(false);
            win_menu.SetActive(true);
            Time.timeScale = 0f;

            //RetryMenuUI.SetActive(true);
            //PlayerIsDied = true;
        }
    
    }
}
