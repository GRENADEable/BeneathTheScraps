using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class GameManagerOutro : MonoBehaviour
{
    #region Public Variables
    public Animator fadeBG;
    public PlayableDirector outroTimeline;
    public GameObject loadingText;
    #endregion

    #region Unity Callbacks
    void Start()
    {
        fadeBG.Play("FadeIn");
        outroTimeline.Play();
    }
    #endregion

    #region My Functions
    public void EndOutroFinished() => StartCoroutine(EndOutroFinishedDelay());
    #endregion

    #region Coroutines
    IEnumerator EndOutroFinishedDelay()
    {
        fadeBG.Play("FadeOut");
        yield return new WaitForSeconds(1f);
        loadingText.SetActive(true);
        SceneManager.LoadScene("MENU_V2");
    }
    #endregion
}