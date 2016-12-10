using UnityEngine;
using System.Collections;
using System;

public class PracticeMode : LearnSong
{
    public TextMesh text;
    void Start() {
        i = 0;
        i = 0;
        k = 0;
        isActive = false;
        colors.Add(1, Color.blue);
        colors.Add(2, Color.green);
        colors.Add(3, Color.cyan);
        text.GetComponent<Renderer>().enabled = false;


    }
    public override void notify(GameObject note)
    {
        note.GetComponent<AudioSource>().Play();
        if (note.transform.name.Equals(currentSong.getNotes()[i]))
        {
            //first note in song
            if (i == 0)
            {
                text.GetComponent<Renderer>().enabled = false;
                i++;
            }
            //end of song has been reached
            else if (i == currentSong.getNotes().Length - 1)
            {
                i = 0;
                j = 0;
                text.GetComponent<Renderer>().enabled = true;
                text.SendMessage("Good job!");
            }
            else
            {
                i++;
                j++;
            }

            k++;
            currentNote = allNotes.NoteManager[currentSong.getNotes()[i]];
            previousNote = allNotes.NoteManager[currentSong.getNotes()[j]];

            if (currentNote != previousNote)
            {
                changeColor(currentNote, colors[k]);
                changeColor(previousNote, Color.white);
            }
            changeColor(currentNote, colors[k]);
            if (k == 3)
            {
                k = 1;
            }

        }
    }

    public override void notifyOnRelease(GameObject note)
    {}

    public void refresh()
    {
        i = 0;
        j = 0;
        k = 0;
        currentNote = allNotes.NoteManager[currentSong.getNotes()[0]];
        changeColor(currentNote, Color.green);


    }
}
