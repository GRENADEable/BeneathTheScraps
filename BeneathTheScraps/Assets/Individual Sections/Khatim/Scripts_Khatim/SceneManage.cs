using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage : MonoBehaviour
{
    public void OpenURL()
    {
        Application.OpenURL("https://drive.google.com/file/d/1YfjO9Oq4D7WU5M4Tog9bk96t1IqjMEfM/view");
        Debug.Log("URL Opened");
    }
}