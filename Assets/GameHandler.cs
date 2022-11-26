using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameHandler : MonoBehaviour
{
    public static int numberofCoins = 0;
    public static int totalJump = 0;
    public TextMeshProUGUI coinText;
    public TextMeshProUGUI jump_text;
    public AudioSource game_sound;

    void Start()
    {
        Invoke("adding_jumps", 0f);
        
    }

    
    void Update()
    {
        coinText.text = "coin : " + numberofCoins;
        jump_text.text = "Jumps : " + totalJump;


        /*if(Time.timeScale == 1)
        {
            game_sound.Play();
        }
        else if(Time.timeScale == 0)
        {
            game_sound.Pause();
        }*/

    }

    void adding_jumps()
    {
        totalJump++;
        Invoke("adding_jumps", 15f);
    }
}
