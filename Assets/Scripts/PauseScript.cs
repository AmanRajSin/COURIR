using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseScript : MonoBehaviour {

    public GameObject pauseLabel;
    public GameObject quitBut;
    public GameObject panel;

    private bool isPaused = false;

	public void PlayPause()
    {
        if(!isPaused)
        {
            Time.timeScale = 0;
            pauseLabel.SetActive(true);
            quitBut.SetActive(true);
            panel.GetComponent<Image>().color = new Color(256f, 256f, 256f, 0.35f);
        }
        else
        {
            Time.timeScale = 1;
            pauseLabel.SetActive(false);
            quitBut.SetActive(false);
            panel.GetComponent<Image>().color = new Color(256f, 256f, 256f, 0f);
        }
        isPaused = !isPaused;
    }
}
