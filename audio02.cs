using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class audio02 : MonoBehaviour
{
    public static bool GameIsPause = false;
    public GameObject pauseAudio;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPause) { Resume(); }
            else { Pause(); }
        }
    }


    public void Resume()
    {
        pauseAudio.SetActive(true);
        
        GameIsPause = false;
    }

    public void Pause()
    {
        pauseAudio.SetActive(false);
        
        GameIsPause = true;
    }
}
