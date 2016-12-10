using UnityEngine;
using System.Collections;

public class FreeMode : MonoBehaviour {
    private bool isActive;
	void Start () {
        isActive = false;
	    
	}
    public bool getState() {
        return isActive;
    }
    public void setState(bool state) {
        this.isActive = state;
    } 
	}