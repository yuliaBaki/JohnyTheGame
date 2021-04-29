using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Key : MonoBehaviour
{
	public DoorScript doorScript;
	public bool foundKey = false;
	public Text changingText;

    void OnTriggerEnter (Collider other)
    {
        if (other.CompareTag("Player") ){
			foundKey = true;
			changingText.text = "Escape trought the door!";
            KeyTouchedByPlayer();
        }
    }

    void KeyTouchedByPlayer()
    {
		doorScript.open = true;
		this.gameObject.SetActive(false);

    }
}
