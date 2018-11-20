using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardMovement : MonoBehaviour {
    float percentMoved;
    // Use this for initialization
    void Start () {
        if (Input.touchCount > 0)
        {
            Touch mytouch = Input.touches[0];
            percentMoved = mytouch.deltaPosition.x/Screen.width;
        }
    }
	
	// Update is called once per frame
	void Update ()
    {

    }
	}
}
