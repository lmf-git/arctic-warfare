using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wait : MonoBehaviour
{

    public float Wait_Time = 10f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Wait_For_Intro());
    }

    IEnumerator Wait_For_Intro()
    {
        yield return new WaitForSeconds(Wait_Time);

        SceneManager.LoadScene(1);

        if (Input.GetKeyDown(KeyCode.M))
        {
            Wait_Time = 0f;
            Debug.Log("NullCorrect");
            SceneManager.LoadScene(1);
        }
    }

    void update()
    {

    }

}
