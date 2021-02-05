using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//EDITING FOR DECOMP - RENDANG 1601 1720
public class gamepause : MonoBehaviour
{
    //public static bool gameIsPaused = false;
    public GameObject pausecanvas;

    //camera script
    public GameObject headobject; //your other object 
    public string camerascript;

    //movement script
    public GameObject fpsplayer; //your other object 
    public string movescript;
    //TIMER SCRIPT
    public timercontroller timescript;
    //public gameflow1 gameflowscript;

    //original script
    //public string SC_FPSController;

    void Update()
    {
        //old method
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("pressed ESC key once");

            //gameflowscript.timerIsRunning = false;
            Debug.Log("PAUSE GAME-TIMER");
            //Debug.Log(gameflowscript.timeRemaining);

            //gameIsPaused = !gameIsPaused;
            Time.timeScale = 0f;
            //AFTER STOP TIME ONLY CALCULATE STOPPED TIME/DURATION
            Debug.Log(timescript.timePlaying.ToString("mm':'ss'.'ff"));
            var inttime = (int)Time.time;
            Debug.Log("Time in int form = " + inttime);

            pausecanvas.SetActive(true);

            //unlock cursor | show cursor
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            
            //disable camera movement script
            (headobject.GetComponent(camerascript) as MonoBehaviour).enabled = false;
        }
    }

    //by pressing button
    public void ResumeGame()
    {
        //gameflowscript.timerIsRunning = true;
        Debug.Log("RESUME GAME-TIMER");
        //Debug.Log(gameflowscript.timeRemaining);

        //gameIsPaused = !gameIsPaused; 
        Time.timeScale = 1;
        pausecanvas.SetActive(false);

        //lock cursor | hide cursor
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        //enable camera movement script
        (headobject.GetComponent(camerascript) as MonoBehaviour).enabled = true;

        //original  please enable
        //(fpsplayer.GetComponent(SC_FPSController) as MonoBehaviour).enabled = true;
    }

    public void ChangeScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    /*public void PauseGame()
    {
        if (gameIsPaused)
        {

            gameIsPaused = true;
            Time.timeScale = 0f;
            pausecanvas.SetActive(true);

            //unlock cursor | show cursor
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;

            //disable camera movement script
            (headobject.GetComponent(camerascript) as MonoBehaviour).enabled = false;

            //disable movement
            //(fpsplayer.GetComponent(movescript) as MonoBehaviour).enabled = false;
        }
        else
        {
            ResumeGame();

            //by pressing key
            gameIsPaused = false;
            Time.timeScale = 1;
            pausecanvas.SetActive(false);

            //lock cursor | hide cursor
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;

            //enable camera movement script
            (headobject.GetComponent(camerascript) as MonoBehaviour).enabled = true;

            //enable movement
            //(fpsplayer.GetComponent(movescript) as MonoBehaviour).enabled = true;
        }
    }*/

}
//ADDED PLAYER MOVEMENT AND CAMERA MOVEMENT (https://sharpcoderblog.com/blog/unity-3d-fps-controller)
//ADDED CURSOR HIDE/SHOW DURING PAUSE AND RESUME
//REMOVED ESCAPE KEY FOR RESUME, ESC KEY ONLY FOR PAUSE NOT FOR RESUME
//ADDED NEW PLAYEROBJECT AND CORRECTED PAUSE/RESUME CAMERA|MOVEMENT ISSUES
