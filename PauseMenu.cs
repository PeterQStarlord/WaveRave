using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {

    public string resume;

    public bool isPaused;

    public GameObject pauseMenuCanvas;

	void Update () {

        if (isPaused)
        {
            pauseMenuCanvas.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            pauseMenuCanvas.SetActive(false);
            Time.timeScale = 1f;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
        }
            
     }

    public void Resume()
    {
        isPaused = false;
    }

    public void QuitGame()
    {
        Debug.Log("Game has been Quit");
        Application.Quit();
    }
}
