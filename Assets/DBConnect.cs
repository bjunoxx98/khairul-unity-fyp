using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DBConnect : MonoBehaviour
{
    public Text email;
    public Text name;
    public Text score; 
    public Text password;

    public void AddDetails()
    {
        StartCoroutine(AddPlayerDetails());
    }

    public void GetDetails()
    {
        StartCoroutine(RetrievePlayerDetails());
    }

    public void UpdateDetails()
    {
        StartCoroutine(UpdatePlayerDetails());
    }

    //1 ADD PLAYER
    IEnumerator AddPlayerDetails()
    {
        Debug.Log("Adding Details");

        WWWForm form = new WWWForm();
        form.AddField("email", email.text); 
        form.AddField("name", name.text);
        form.AddField("score", score.text);
        form.AddField("password", password.text);
        WWW www = new WWW("yourwebsite.php", form); //change "yourwebsite.php" to your own php file;

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

    //2 RETRIEVE PLAYER
    IEnumerator RetrievePlayerDetails()
    {
        Debug.Log("Retrieving Details");

        WWWForm form = new WWWForm();
        form.AddField("email", email.text);
        form.AddField("password", password.text);
        WWW www = new WWW("yourwebsite.php", form); //change "yourwebsite.php" to your own php file

        yield return www;
        if (www.error != null)
        {
            Debug.Log(www.error);
        }
        else
        {
            Debug.Log(www.text);
            string[] details = www.text.Split('|');
            name.transform.parent.GetComponent<InputField>().text = details[0];
            if (details.Length > 2)
            {
                score.transform.parent.GetComponent<InputField>().text = details[1];
            }
        }
    }

    //3 UPDATE PLAYER
    IEnumerator UpdatePlayerDetails()
    {
        Debug.Log("Updating Details");

        WWWForm form = new WWWForm();
        form.AddField("email", email.text);
        form.AddField("name", name.text);
        form.AddField("score", score.text);
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
