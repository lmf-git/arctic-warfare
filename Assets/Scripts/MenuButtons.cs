using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayGame ()
    {
        SceneManager.LoadScene(2);
    }

    // Update is called once per frame
    public void QuitGame ()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
