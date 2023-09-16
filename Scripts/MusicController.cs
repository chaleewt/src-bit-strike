using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{

    GameObject[] musicPlayer;


    void Awake()
    {
        musicPlayer = GameObject.FindGameObjectsWithTag("MusicPlayer");

        if (musicPlayer.Length > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }    
    }
}
