using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//EDITING FOR DECOMP-02-asamp 2201 2030
public class gameflow2 : MonoBehaviour
{
    public GameObject startcanvas;
    public GameObject textStep1;
    public GameObject completemessage;
    public GameObject failmessage;
    public GameObject endcanvas;
    public GameObject star1;
    public GameObject star2;
    public GameObject star3;
    public GameObject score100;
    public GameObject score50;
    public GameObject score20;
    public GameObject scorecanvas;
    public bool gamePlaying = false;
    private bool stageComplete = false;
    public bool postComplete = false;
    public bool endmessage = false;
    //calling other script
    public planeingcategorymeat02 meat;
    public planeingcategoryvegie02 vegie;
    public planeingcategoryliquid02 liquid;
    public planeingcategoryspice02 spice;
    public timercontroller timescript;
    public logindb loginscript;

    //camera script
    public GameObject headobject; //your other object 
    public string camerascript;

    //TIMER
    public float timeRemaining;
    public bool timerIsRunning = false;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0f;
        startcanvas.SetActive(true);

        //unlock cursor | show cursor
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        //disable camera movement script
        (headobject.GetComponent(camerascript) as MonoBehaviour).enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //CHECK TIMER
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                if (endmessage == false)
                {
                    Debug.Log("Time has run out!");

                    Debug.Log("GAME FINISH METHOD");

                    //unlock cursor | show cursor
                    Cursor.visible = true;
                    Cursor.lockState = CursorLockMode.None;

                    //disable camera movement script
                    (headobject.GetComponent(camerascript) as MonoBehaviour).enabled = false;

                    //TIME CONTROL
                    stageComplete = true;
                    timercontroller.instance.EndTimer();

                    //gameIsPaused = !gameIsPaused;
                    Time.timeScale = 0f;
                    timeRemaining = 0;
                    timerIsRunning = false;
                    //DISPLAY 0 STARS
                    //FAILED STAGE
                    endcanvas.SetActive(true);
                    completemessage.SetActive(false);
                    failmessage.SetActive(true);
                    endmessage = true;
                }
            }
        }

        if (meat.gameComplete == true && vegie.gameComplete == true && liquid.gameComplete == true && spice.gameComplete == true)
        {
            //GAMEWON FINISH
            //GAMEEND

            //unlock cursor | show cursor
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;

            //disable camera movement script
            (headobject.GetComponent(camerascript) as MonoBehaviour).enabled = false;

            //TIME CONTROL
            stageComplete = true;
            timercontroller.instance.EndTimer();

            //gameIsPaused = !gameIsPaused;
            Time.timeScale = 0f;

            //CHECK TIME TO COMPLETE THE GAME IN INT (SECONDS)
            if (timeRemaining > 25)   //3 STAR  1:30
            {
                //DISPLAY 3 STARS
                endcanvas.SetActive(true);
                completemessage.SetActive(true);
                failmessage.SetActive(false);
                star1.SetActive(true);
                star2.SetActive(true);
                star3.SetActive(true);
                score100.SetActive(true);       //new UI
                scorecanvas.SetActive(true);
                //ASSIGN SCORE TO 100

                int starscore3 = 100;
                //email
                string emailvalue = logindb.getemail;
                if (postComplete == false)
                {
                    postComplete = true; 
                    Debug.Log("TIME REMAINING = " + timeRemaining);
                    PostScores(starscore3, emailvalue);
                    Debug.Log("POSTING SCOREE 3 ....");
                    Debug.Log(starscore3);
                    Debug.Log(emailvalue);
                }
            }
            else if (timeRemaining > 15)  //2 STAR   1:40
            {
                //DISPLAY 2 STARS
                endcanvas.SetActive(true);
                completemessage.SetActive(true);
                failmessage.SetActive(false);
                star1.SetActive(true);
                star2.SetActive(true);
                score50.SetActive(true);       //new UI
                scorecanvas.SetActive(true);

                int starscore2 = 50;
                //email
                string emailvalue = logindb.getemail;
                if (postComplete == false)
                {
                    postComplete = true; 
                    Debug.Log("TIME REMAINING = " + timeRemaining);
                    PostScores(starscore2, emailvalue);
                    Debug.Log("POSTING SCOREE 2 ....");
                    Debug.Log(starscore2);
                    Debug.Log(emailvalue);
                }
            }
            else if (timeRemaining > 5)  //1 STAR 1:50
            {
                //DISPLAY 1 STARS
                endcanvas.SetActive(true);
                completemessage.SetActive(true);
                failmessage.SetActive(false);
                star1.SetActive(true);
                score20.SetActive(true);       //new UI
                scorecanvas.SetActive(true);

                int starscore1 = 20;
                //email
                string emailvalue = logindb.getemail;
                if (postComplete == false)
                {
                    postComplete = true; 
                    Debug.Log("TIME REMAINING = " + timeRemaining);
                    PostScores(starscore1, emailvalue);
                    Debug.Log("POSTING SCOREE 1 ....");
                    Debug.Log(starscore1);
                    Debug.Log(emailvalue);
                }

            }
            else
            {
                //DISPLAY 0 STAR
                //FAILED STAGE
                if (endmessage == false)
                {
                    endcanvas.SetActive(true);
                    completemessage.SetActive(false);
                    failmessage.SetActive(true);
                    Debug.Log("TIME REMAINING = " + timeRemaining);
                    endmessage = true;
                }
                //IF SCORE = 0 , DONT HAVE TO POST SCORE TO DATABASE
            }

        }
    }

    public void startGame()
    {
        //TRY CREATE TIMER https://gamedevbeginner.com/how-to-make-countdown-timer-in-unity-minutes-seconds/
        timerIsRunning = true;
        timeRemaining = 90; //LEVEL 1 SET TIMER TO 1:30 BEFORE GAME STOP

        Debug.Log("START GAME-TIMER");
        Debug.Log(timeRemaining);

        Time.timeScale = 1;
        startcanvas.SetActive(false);
        textStep1.SetActive(true);

        gamePlaying = true;
        timercontroller.instance.BeginTimer();

        //lock cursor | hide cursor
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        //enable camera movement script
        (headobject.GetComponent(camerascript) as MonoBehaviour).enabled = true;
    }

    //2nd method
    public void PostScores(int score, string email)     // <WORKING 2201-2000
    {
        Debug.Log("Updating Details");
        Debug.Log(score);
        Debug.Log(email);

        WWWForm form = new WWWForm();
        form.AddField("email", email);
        form.AddField("score2", score);    //<----- changed to score3
        WWW www = new WWW("yourwebsite.php", form); //change "yourwebsite.php" to your own php file
    }
}
//ADDED PLAYER MOVEMENT AND CAMERA MOVEMENT (https://sharpcoderblog.com/blog/unity-3d-fps-controller)
//ADDED CURSOR HIDE/SHOW DURING PAUSE AND RESUME
//REMOVED ESCAPE KEY FOR RESUME, ESC KEY ONLY FOR PAUSE NOT FOR RESUME
//ADDED NEW PLAYEROBJECT AND CORRECTED PAUSE/RESUME CAMERA|MOVEMENT ISSUES
