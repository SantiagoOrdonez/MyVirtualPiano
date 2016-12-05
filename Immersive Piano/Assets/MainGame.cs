using UnityEngine;
using System.Collections;

public class MainGame : MonoBehaviour {

    public FreeMode freeMode;
    public LearnSongModeScreen learnSongMode;
    public TwinkleLittleStar twinkle;

    void Start() {
    }
    void Update() {
       
	}
    public string getMode() {
        if (learnSongMode.getState())
        {
            return "learnSongMode";
        }
        else if (freeMode.getState())
        {
            return "freeMode";
        }
        return "";
    }
}
