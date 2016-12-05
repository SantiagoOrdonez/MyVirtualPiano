using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public interface Playable : IEventSystemHandler{
    void PlaySound();
}

