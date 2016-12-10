using UnityEngine;
using System.Collections;
using System;

public class PianoNote : MonoBehaviour, Playable{
    public ParticleSystem particleEffect;
    private AudioSource audio;
    private Renderer render;
    public LearnSongModeScreen learnSongModeScreen;
    public MainGame game;
    // Use this for initialization
    void Start () {
        audio = GetComponent<AudioSource>();
	}
    public void PlaySound()
    {
        //Instantiate(particleEffect,transform.position,transform.rotat)
        string mode = game.getMode();
        if (mode.Equals("learnSongMode")) {
            learnSongModeScreen.getCurrentMode().notify(this.gameObject);
        } else if (mode.Equals("freeMode")) {
            audio.Play();
            if (transform.childCount == 0)
            {
                Renderer renderer = GetComponent<Renderer>();
                renderer.material.color = Color.red;
            }
            else
            {
                foreach (Renderer rend in GetComponentsInChildren<Renderer>())
                {
                    rend.material.color = Color.red;
                }
            }
        }
       
    }

}
