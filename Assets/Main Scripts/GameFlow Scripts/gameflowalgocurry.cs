using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//THIS IS FOR ALGO - CURRY ONLY 1901-1730
public class gameflowalgocurry : MonoBehaviour
{
    public GameObject startcanvas;
    public GameObject textStep1; 
    public GameObject endcanvas;
    public GameObject completemessage;
    public GameObject failmessage;
    public GameObject followstepmessage;
    public GameObject timeupmsg;
    public GameObject star1;
    public GameObject star2;
    public GameObject star3;
    public GameObject score100;
    public GameObject score50;
    public GameObject score20;
    public GameObject scorecanvas;
    public bool gamePlaying = false;
    public bool postComplete = false;
    public bool endmessage = false;
    public logindb loginscript;

    //camera script
    public GameObject headobject; //your other object 
    public string camerascript;

    //TIMER TRY
    public float timeRemaining;
    public float delaytime = 2;
    public float delaytimeok = 3;
    public bool timerIsRunning = false;

    public endplatformpotcurry epscriptcurry;

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
        if (timerIsRunning == true)
        {
            if (timeRemaining > 0 && epscriptcurry.stageComplete == true)
            {
                //TIME CONTROL  --PAUSE THE TIMER ON LEFT SCREEN
                timercontroller.instance.EndTimer();

                //GAMEWON FINISH
                if (delaytimeok > 0)
                {
                    delaytimeok -= Time.deltaTime;
                }
                else
                {
                    //unlock cursor | show cursor
                    Cursor.visible = true;
                    Cursor.lockState = CursorLockMode.None;

                    //disable camera movement script
                    (headobject.GetComponent(camerascript) as MonoBehaviour).enabled = false;

                    //gameIsPaused = !gameIsPaused;
                    Time.timeScale = 0f;

                    //CHECK TIME TO COMPLETE THE GAME IN INT (SECONDS)
                    if (timeRemaining > 15)   //3 STAR  0:25
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
                        if (postComplete == false)  //CALL THIS ONCE
                        {
                            postComplete = true;
                            Debug.Log("TIME REMAINING = " + timeRemaining);
                            PostScores(starscore3, emailvalue);
                            Debug.Log("POSTING SCOREE 3 ....");
                            Debug.Log(starscore3);
                            Debug.Log(emailvalue);
                        }
                    }
                    else if (timeRemaining > 10)  //2 STAR   0:30
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
                        if (postComplete == false)  //CALL THIS ONCE
                        {
                            postComplete = true;
                            Debug.Log("TIME REMAINING = " + timeRemaining);
                            PostScores(starscore2, emailvalue);
                            Debug.Log("POSTING SCOREE 2 ....");
                            Debug.Log(starscore2);
                            Debug.Log(emailvalue);
                        }
                    }
                    else if (timeRemaining > 5)  //1 STAR 0:35
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
                        if (postComplete == false)  //CALL THIS ONCE
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
                            endmessage = true; 
                            endcanvas.SetActive(true);
                            completemessage.SetActive(false);
                            failmessage.SetActive(true);
                            Debug.Log("TIME REMAINING = " + timeRemaining);
                        }
                        //IF SCORE = 0 , DONT HAVE TO POST SCORE TO DATABASE
                    }
                    Debug.Log("timerIsRunning = false");
                    timerIsRunning = false; //STOP CALLING THIS IF STATEMENT IN UPDATE METHOD
                }
            }
            else if (timeRemaining > 0 && epscriptcurry.terminategame == true)
            {
                Debug.Log("CHECK IF TERMINATE FUNCTION WORKS");
                //TERMINATE GAME COMPLETELY
                //DO OPERATIONS BELOW
                if (delaytime > 0)
                {
                    delaytime -= Time.deltaTime;
                }
                else
                {
                    //unlock cursor | show cursor
                    Cursor.visible = true;
                    Cursor.lockState = CursorLockMode.None;

                    //disable camera movement script
                    (headobject.GetComponent(camerascript) as MonoBehaviour).enabled = false;

                    //TIME CONTROL
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
                    followstepmessage.SetActive(true);
                    endmessage = true;
                }
            }
            else if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else  //IF THE TIMER REACHED ZERO 0 > END GAME
            {
                if (endmessage == false)    //to call this only once
                {
                    Debug.Log("Time has run out!");

                    //unlock cursor | show cursor
                    Cursor.visible = true;
                    Cursor.lockState = CursorLockMode.None;

                    //disable camera movement script
                    (headobject.GetComponent(camerascript) as MonoBehaviour).enabled = false;

                    //TIME CONTROL
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
                    timeupmsg.SetActive(true); 
                    endmessage = true;
                }
            }
        }
    }

    public void startGame()
    {
        //TRY CREATE TIMER https://gamedevbeginner.com/how-to-make-countdown-timer-in-unity-minutes-seconds/
        timerIsRunning = true;
        timeRemaining = 90; // SET TIMER TO 1:20 BEFORE GAME STOP

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
    //POST SCORE INTO DATABASE
    public void PostScores(int score, string email)
    {
        Debug.Log("Updating Details");
        Debug.Log(score);
        Debug.Log(email);

        WWWForm form = new WWWForm();
        form.AddField("email", email);
        form.AddField("score12", score);    //<----- changed to score12
        WWW www = new WWW("yourwebsite.php", form); //change "yourwebsite.php" to your own php file
    }
}
//ADDED PLAYER MOVEMENT AND CAMERA MOVEMENT (https://sharpcoderblog.com/blog/unity-3d-fps-controller)
//ADDED CURSOR HIDE/SHOW DURING PAUSE AND RESUME
//REMOVED ESCAPE KEY FOR RESUME, ESC KEY ONLY FOR PAUSE NOT FOR RESUME
//ADDED NEW PLAYEROBJECT AND CORRECTED PAUSE/RESUME CAMERA|MOVEMENT ISSUES
