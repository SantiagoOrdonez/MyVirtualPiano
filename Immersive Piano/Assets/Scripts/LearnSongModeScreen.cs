using UnityEngine;
using System.Collections;

public class LearnSongModeScreen : MonoBehaviour {
    private LearnSong learnSongMode;
    protected bool isActive;
    public GameObject menu;
    public TwinkleLittleStar twinkleLittleStar;
    public MyNotes allNotes;
    void Start () {
        menu.SetActive(false);
	}
    public void activateMenu(bool state) {
        menu.SetActive(state);
    }
    public void setCurrentMode(LearnSong mode) {
        this.learnSongMode = mode;
        learnSongMode.setSong(twinkleLittleStar);
        clear();
    }
    public LearnSong getCurrentMode() {
        return this.learnSongMode;
    }
    public bool getState()
    {
        return isActive;
    }
    public void setState(bool state)
    {
        this.isActive = state;
    }
    public void clear() {
        foreach (string note in learnSongMode.getSong().getNotes())
        {
            GameObject currentNote = allNotes.NoteManager[note];
            if (currentNote.transform.childCount == 0)
            {
                Renderer renderer = currentNote.GetComponent<Renderer>();
                renderer.material.color = Color.black;
            }
            else
            {
                foreach (Renderer rend in currentNote.GetComponentsInChildren<Renderer>())
                {
                    rend.material.color = Color.white;
                }
            }
        }
    }
}
