using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class TwinkleLittleStar : MonoBehaviour, Song{
    string[] notes= { "G4", "G4", "D5", "D5", "E5", "E5", "D5" ,
                       "C5", "C5", "B4", "B4", "A4", "A4", "G4" ,
                       "D5", "D5", "C5", "C5", "B4", "B4", "A4" ,
                       "D5", "D5", "C5", "C5", "B4", "B4", "A4" ,
                       "G4", "G4", "D5", "D5", "E5", "E5", "D5" ,
                       "C5", "C5", "B4", "B4", "A4", "A4", "G4" };

    float[] noteTimes= {0.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f,
                         2.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f,
                         2.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f,
                         2.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f,
                         2.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f,
                         2.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f };


    // Update is called once per frame
    public string[] getNotes()
    {
        return notes;
    }
    public float[] getNoteTimes() {
        return noteTimes;
    }
}
