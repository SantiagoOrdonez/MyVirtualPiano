using UnityEngine;
using System.Collections;
using System;

public interface Song
{
    string[] getNotes();
    float[] getNoteTimes();
}