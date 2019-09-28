using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryScript : MonoBehaviour {


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
            Retry();
    }

	public void Retry()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }
}
