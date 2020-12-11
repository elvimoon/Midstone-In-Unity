using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioPlayer : MonoBehaviour
{
    private AudioSource playSound;
    public GameObject player;
    public AudioClip gameMusic;
    public AudioClip victoryMusic;


    private void Start()
    {
        playSound = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (player == null)
        {
            playSound.clip = victoryMusic;
            playSound.Play();
        }

    }
}
