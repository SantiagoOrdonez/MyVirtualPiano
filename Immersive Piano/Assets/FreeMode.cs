using UnityEngine;
using System.Collections;

public class FreeMode : MonoBehaviour {

    private bool isActive;
	void Start () {
        isActive = true;
	    
	}
    public bool getState() {
        return isActive;
    }

    public void setState(bool state) {
        this.isActive = state;
    } 
	}