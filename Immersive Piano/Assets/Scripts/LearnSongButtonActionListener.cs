using UnityEngine;
using System.Collections;
using System;

public class LearnSongButtonActionListener : MonoBehaviour
{
    public WatchMode watchMode;
    public PracticeMode practiceMode;
    public LearnSongModeScreen learnSongScreen;
    public PlayIt playMode;
    public MainGame game;

    public void activateWatchMode()
    {
        learnSongScreen.setCurrentMode(watchMode);
        watchMode.playSong();
    }
    public void activatePracticeMode()
    {
        learnSongScreen.setCurrentMode(practiceMode);
        watchMode.stopSong();
        practiceMode.refresh();

    }
    public void activatePlayMode()
    {
        learnSongScreen.setCurrentMode(playMode);
        watchMode.stopSong();
        playMode.refresh();

    }

}