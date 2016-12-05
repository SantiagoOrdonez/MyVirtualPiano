using UnityEngine;
using System.Collections;

public class WatchMode : LearnSong{
    private float startTime;
    private bool flag;
    void Start() {
        i = 0;
        i = 0;
        k = 0;
        isActive = false;
        colors.Add(1, Color.blue);
        colors.Add(2, Color.green);
        colors.Add(3, Color.cyan);
        startTime = Time.time;
        flag = false;
    }
    void Update() {

        if (this.flag) {
            if (k == 3)
            {
                k = 1;
            }
            k++;
            currentNote = allNotes.NoteManager[currentSong.getNotes()[i]];
            previousNote = allNotes.NoteManager[currentSong.getNotes()[j]];
            if (Time.time - startTime > currentSong.getNoteTimes()[i])
            {
                currentNote.GetComponent<AudioSource>().Play();
                this.changeColor(currentNote, colors[k]);
                if (i != 0 && previousNote != currentNote)
                {
                    this.changeColor(previousNote, Color.white);
                    j++;
                }
                startTime = Time.time;
                i++;
            }
            else if (Time.time - startTime > currentSong.getNoteTimes()[i] - 0.5f)
            {
                this.changeColor(currentNote, Color.white);

            }
            if (i >= currentSong.getNotes().Length)
            {
                i = 0;
                j = 0;
                this.flag = false;
            }
        }
}
    public override void notify(GameObject note){}
    public void playSong() {
        this.flag = true;
    }
    public void stopSong() {
        this.flag = false;
        i = 0;
        j = 0;
        k = 0;
    }
    public override void notifyOnRelease(GameObject note){}
}
