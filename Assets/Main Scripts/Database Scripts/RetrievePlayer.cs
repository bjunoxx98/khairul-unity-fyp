using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RetrievePlayer : MonoBehaviour
{
    public void GetDetails()
    {
        StartCoroutine(RetrievePlayerDetails());
    }

    IEnumerator RetrievePlayerDetails()
    {
        Debug.Log("Retrieving Details");

        WWWForm form = new WWWForm();
        WWW www = new WWW("yourwebsite.php", form); //change "yourwebsite.php" to your own php file

        yield return www;
        if (www.error != null)
        {
            Debug.Log(www.error);
        }
        else
        {
            Debug.Log(www.text);
        }
    }
}
