using UnityEngine;
using System.Collections;

public class ButtonActionListener : MonoBehaviour {
    public FreeMode freeMode;
    public LearnSongModeScreen learnSongModeScreen;
    public GameObject learnSongMenu;
    public GameObject menu;
    public GameObject notes;
    public AudioSource song; 

    public void activateFreeMode() {
        freeMode.setState(true);
        song.Pause();
    }
    public void activateLearnSongMode(){
        learnSongModeScreen.activateMenu(true);
        learnSongModeScreen.setState(true);
        freeMode.setState(false);
        menu.SetActive(false);
        song.Pause();


    }
    public void returnToMenu() {
        freeMode.setState(true);
        menu.SetActive(true);
        learnSongModeScreen.activateMenu(false);
        learnSongModeScreen.setState(false);



    }
}
