using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SCTutorial : MonoBehaviour
{
    public void Change()
    {
        SceneManager.LoadScene("Tutorial");
    }
}
