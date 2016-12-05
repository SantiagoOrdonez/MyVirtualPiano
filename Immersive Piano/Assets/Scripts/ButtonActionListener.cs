using UnityEngine;
using System.Collections;

public class ButtonActionListener : MonoBehaviour {
    public FreeMode freeMode;
    public LearnSongModeScreen learnSongModeScreen;
    public GameObject learnSongMenu;
    public GameObject menu;
    public GameObject notes;
    public void activateFreeMode() {
        freeMode.setState(true);
    }
    public void activateLearnSongMode(){
        learnSongModeScreen.activateMenu(true);
        learnSongModeScreen.setState(true);
        freeMode.setState(false);
        menu.SetActive(false);

    }
}
