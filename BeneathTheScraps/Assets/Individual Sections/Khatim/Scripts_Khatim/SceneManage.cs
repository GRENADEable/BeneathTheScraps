using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage : MonoBehaviour
{
    public void StartScene()
    {
        SceneManager.LoadScene("AR_FINAL");
        Debug.Log("Scene Started");
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Application Closed");
    }
}