using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SCGameover : MonoBehaviour
{
    public void Change()
    {
        SceneManager.LoadScene("Gameover");
    }
}
