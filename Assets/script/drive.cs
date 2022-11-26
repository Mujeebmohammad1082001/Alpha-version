using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class drive : MonoBehaviour
{
    public float speed;
    public float up_Force;
    public Rigidbody rb;
    int chooseLane;
    public GameObject coin;
    int lineSize;
    public GameObject Player;
    public GameObject RetryMenuUI;
    public AudioClip crashSound;
    public AudioSource game_sound;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("spawn_coins", 0f);
        Invoke("totalJump",0f);
    
    }

    // Update is called once per frame
    void Update()
    {
        //speed
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        if(Input.GetKeyDown("right"))
        {

            if(transform.position.x <= 0 && Time.timeScale != 0)
            transform.position = new Vector3(transform.position.x + 7, transform.position.y,transform.position.z);
        }
        

        else if(Input.GetKeyDown("left") && Time.timeScale != 0)
        {
            if(transform.position.x >= 0)
            transform.position = new Vector3(transform.position.x -7, transform.position.y ,transform.position.z);
        }

        if(Input.GetKeyDown("up") && transform.position.y <= 1 && GameHandler.totalJump > 0 && Time.timeScale != 0)
        {
            rb.AddForce(0, up_Force, 0, ForceMode.Impulse);
            GameHandler.totalJump--;
        }
        
    }

    void spawn_coins()
    {
        chooseLane = Random.Range(1,4);
        if(chooseLane == 1)
        {
            lineSize = 7;
        }
        else if(chooseLane == 2)
        {
            lineSize = 0;
        }

        else if(chooseLane ==3)
        {
            lineSize = -7;
        }
        Instantiate(coin, new Vector3(lineSize, 0, Player.transform.position.z + 30), Quaternion.identity);
        Invoke("spawn_coins", 1);
    }


        private void OnCollisionEnter(Collision collision) 
    {

    if(collision.gameObject.tag == "car")
        {
            game_sound.Pause();
            AudioSource.PlayClipAtPoint(crashSound, transform.position);
            RetryMenuUI.SetActive(true);
            Time.timeScale = 0f;
            Debug.Log("You Lost");
            


        }
    
    }
}
