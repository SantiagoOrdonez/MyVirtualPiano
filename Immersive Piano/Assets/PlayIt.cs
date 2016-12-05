using UnityEngine;
using System.Collections;
using System;

public class PlayIt : LearnSong {
    public ParticleSystem pSystem1;
    public ParticleSystem pSystem2;
    public TextMesh textMesh;
    public override void notify(GameObject note)
    {
        note.GetComponent<AudioSource>().Play();
        if (note.transform.childCount == 0)
        {
            Renderer renderer = note.GetComponent<Renderer>();
            renderer.material.color = Color.red;
        }
        else
        {
            foreach (Renderer rend in note.GetComponentsInChildren<Renderer>())
            {
                rend.material.color = Color.red;
            }
        }

        if (note.transform.name.Equals(currentSong.getNotes()[i]))
        {
            textMesh.GetComponent<Renderer>().enabled = false;
            //first note in song
            if (i == 0)
            {
                i++;
            }
            //end of song has been reached
            else if (i == currentSong.getNotes().Length - 1)
            {
                i = 0;
                j = 0;
                pSystem1.Play();
                pSystem2.Play();
                textMesh.text = "Goog Job!";
                textMesh.GetComponent<Renderer>().enabled = true;
            }
            else
            {
                i++;
                j++;
            }

            k++;
            currentNote = allNotes.NoteManager[currentSong.getNotes()[i]];
            previousNote = allNotes.NoteManager[currentSong.getNotes()[j]];
        }
        else {
            i = 0;
            j = 0;
            textMesh.GetComponent<Renderer>().enabled = true;
            textMesh.text = "Wrong note! Try Again!";

        }
    }

    public override void notifyOnRelease(GameObject note)
    {
            if (note.transform.childCount == 0)
            {
                Renderer renderer = note.GetComponent<Renderer>();
                renderer.material.color = Color.black;
            }
            else
            {
                foreach (Renderer rend in note.GetComponentsInChildren<Renderer>())
                {
                    rend.material.color = Color.white;
                }
            }
    }
}
