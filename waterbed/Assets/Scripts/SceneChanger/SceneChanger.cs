using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Change()
    {
        SceneManager.LoadScene("Main");
    }

}
/*
    public void Change()
    {
        if(GameFirstRun == true)
            {
                SceneManager.LoadScene("Story");
            }
        else
            {
                SceneManager.LoadScene("Main");
            }
    }
*/

// test quote for github branch commits