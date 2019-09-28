using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitToMenuScript : MonoBehaviour {

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
            QuitToMenu();
    }

	public void QuitToMenu ()
    {
        SceneManager.LoadScene(0);	
	}
}
