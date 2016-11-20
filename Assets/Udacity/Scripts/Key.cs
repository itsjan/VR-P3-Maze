using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
	public GameObject door;
    //Create a reference to the KeyPoofPrefab and Door
	[Header("When Clicked")]
	public GameObject poofPrefab;


	void Update()
	{
		//Bonus: Key Animation
	}

	public void OnKeyClicked()
	{
        // Instatiate the KeyPoof Prefab where this key is located
        // Make sure the poof animates vertically
        // Call the Unlock() method on the Door
        // Destroy the key. Check the Unity documentation on how to use Destroy

		Object.Instantiate (poofPrefab, gameObject.transform.position, poofPrefab.transform.rotation);
		door.SendMessage ("Unlock");
		Destroy(gameObject);

    }

}
