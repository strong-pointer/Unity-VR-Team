using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChange : MonoBehaviour
{
	public string scene;
	public GameObject removeBlock, removeLock, removeText, addText;
    private void OnTriggerEnter(Collider other)
    {
		if (other.tag == "Player")
		{
			if (removeBlock != null)
			{
				if (scene == "Prehistory")
                {
					PersistentManagerScript.BlockAncEnabled = false;
					PersistentManagerScript.LockAncEnabled = false;
					PersistentManagerScript.RedAncEnabled = false;
					PersistentManagerScript.GreenAncEnabled = true;
				}
				else if (scene == "Ancient HIrtory Room")
                {
					PersistentManagerScript.BlockLateEnabled = false;
					PersistentManagerScript.LockLateEnabled = false;
					PersistentManagerScript.RedLateEnabled = false;
					PersistentManagerScript.GreenLateEnabled = true;
				}
				else if (scene == "LateMiddleAges")
                {
					PersistentManagerScript.BlockModEnabled = false;
					PersistentManagerScript.LockModEnabled = false;
					PersistentManagerScript.RedModEnabled = false;
					PersistentManagerScript.GreenModEnabled = true;
				}

				removeBlock.SetActive(false);
				removeLock.SetActive(false);
				removeText.SetActive(false);
				addText.SetActive(true);
			}
			// Exit the game
			if (scene == "Exit")
            {
				Application.Quit();
			}
			else
            {
				SceneManager.LoadScene(scene);
			}
			
		}
    }
}
