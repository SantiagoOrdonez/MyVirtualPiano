using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class LearnSong : MonoBehaviour
{
    protected int i =0;
    protected int j =0;
    protected int k =0;
    protected bool isActive;
    public MyNotes allNotes;
    protected GameObject currentNote;
    protected GameObject previousNote;
    protected Song currentSong;
    protected Dictionary<int, Color> colors = new Dictionary<int, Color>();

   
    public abstract void notify(GameObject note);
    public abstract void notifyOnRelease(GameObject note);

    public void changeColor(GameObject note, Color color)
    {
        if (note.transform.childCount == 0)
        {
            Renderer renderer = note.GetComponent<Renderer>();
            renderer.material.color = color;
        }
        else
        {
            foreach (Renderer rend in note.GetComponentsInChildren<Renderer>())
            {
                rend.material.color = color;
            }
        }
    }


    public bool getState()
    {
        return isActive;
    }

    public void setState(bool state)
    {
        this.isActive = state;
    }
    public Song getSong()
    {
        return this.currentSong ;
    }
    public void setSong(Song song)
    {
        this.currentSong = song;
    }
    public void refresh() {
        i = 0;
        j = 0;
        k = 0;
    }

}

