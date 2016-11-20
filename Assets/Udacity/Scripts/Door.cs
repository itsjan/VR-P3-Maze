using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
	public bool locked = true;
	public bool opened = false;
	public bool doorIsEnabled = false;
	public AudioClip[] openCloseSoundFiles;
	public AudioSource audioSource;

    // Create a boolean value called "locked" that can be checked in Update() 

    void Update() {
        // If the door is unlocked and it is not fully raised
            // Animate the door raising up

		if (!locked && opened) {
			if (transform.position.y < 20.0f) {
				transform.Translate (0, 10f * Time.deltaTime, 0, Space.World);
			}
		} else if (locked || !opened ){
			if (transform.position.y > 11.5f) {
				transform.Translate (0, -10f * Time.deltaTime, 0, Space.World);
			}
		}

    }

	public void ToggleDoorOnClick(){
		if (!locked && doorIsEnabled) {
			opened = !opened;
			audioSource.clip = openCloseSoundFiles [opened ? 0 : 1];
			audioSource.Play ();
		}
	}

    public void Unlock()
    {
		locked = false;
    }
		

	// from Waypoint
	public void Enable()
	{
		doorIsEnabled = true;
	}
	public void Disable()
	{
		doorIsEnabled = false;
		opened = false;
	}

}
