using UnityEngine;
using System.Collections;
using System;

public class PianoNoteUp : MonoBehaviour {
    public MainGame game;
    public LearnSongModeScreen learnSongModeScreen;

    public void changeColor() {
        string mode = game.getMode();
        if (mode.Equals("freeMode"))
        {
            if (transform.childCount == 0)
            {
                Renderer renderer = GetComponent<Renderer>();
                renderer.material.color = Color.black;
            }
            else
            {
                foreach (Renderer rend in GetComponentsInChildren<Renderer>())
                {
                    rend.material.color = Color.white;
                }
            }
        }
        else {
            learnSongModeScreen.getCurrentMode().notifyOnRelease(this.gameObject);
        }
    }
       
}
