using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageMenu : MonoBehaviour
{
    public Button[] lvlButtons;

    // Start is called before the first frame update
    void Start()
    {
        /*int levelAt = PlayerPrefs.GetInt("levelAt", 0); *//* < Change this int value to whatever your
                                                             level selection build index is on your
                                                             build settings *//*

        for (int i = 0; i < lvlButtons.Length; i++)
        {
            if (i + 1 > levelAt)
                //select index that are not clickable
                lvlButtons[i].interactable = false;
        }*/
    }

}
