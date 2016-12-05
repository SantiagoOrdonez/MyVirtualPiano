using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MyNotes : MonoBehaviour {

    public GameObject C5;
    public GameObject Csharp5;
    public GameObject B4;
    public GameObject A4;
    public GameObject Asharp4;
    public GameObject Gsharp4;
    public GameObject G4;
    public GameObject D5;
    public GameObject Dsharp5;
    public GameObject E5;
    public GameObject F4;
    public GameObject E4;
    public GameObject Dsharp4;
    public GameObject D4;
    public GameObject Csharp4;
    public GameObject C4;
    public GameObject Fsharp3;
    public GameObject G3;
    public GameObject Asharp3;
    public GameObject B3;
    public GameObject Gsharp3;
    public GameObject F3;
    public GameObject A3;
    public GameObject Fsharp4;

    public  Dictionary<string, GameObject> NoteManager  = new Dictionary<string, GameObject>();
    

    // Use this for initialization
    void Start () {
        NoteManager.Add("C5",C5);
        NoteManager.Add("C#5", Csharp5);
        NoteManager.Add("B4", B4);
        NoteManager.Add("A4", A4);
        NoteManager.Add("G4", G4);
        NoteManager.Add("D5", D5);
        NoteManager.Add("D#5", Dsharp5);
        NoteManager.Add("E5", E5);
        NoteManager.Add("F4", F4);
        NoteManager.Add("E4", E4);
        NoteManager.Add("D#4", Dsharp4);
        NoteManager.Add("D4", D4);
        NoteManager.Add("C#4", Csharp4);
        NoteManager.Add("C4", C4);
        NoteManager.Add("F#3", Fsharp3);
        NoteManager.Add("G3", G3);
        NoteManager.Add("A#3", Asharp3);
        NoteManager.Add("B3", B3);
        NoteManager.Add("G#3", Gsharp3);
        NoteManager.Add("F3", F3);
        NoteManager.Add("A3", A3);
        NoteManager.Add("F#4", Fsharp4);
    }

    // Update is called once per frame
    void Update () {
	
	}
}
