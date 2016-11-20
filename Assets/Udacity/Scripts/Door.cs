using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
	public bool locked = true;

    // Create a boolean value called "locked" that can be checked in Update() 

    void Update() {
        // If the door is unlocked and it is not fully raised
            // Animate the door raising up

		if (!locked) {
			if (transform.position.y < 15.0f) {
				transform.Translate (0, 2.5f * Time.deltaTime, 0, Space.World);
			}
		} else {
			if (transform.position.y > 11.5f) {
				transform.Translate (0, -2.5f * Time.deltaTime, 0, Space.World);
			}
		}

    }

    public void Unlock()
    {
		locked = false;
    }
}
