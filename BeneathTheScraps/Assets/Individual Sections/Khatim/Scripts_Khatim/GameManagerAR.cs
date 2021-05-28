using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class GameManagerAR : MonoBehaviour
{
    #region Public Variables
    public Animator fadeBG;
    public GameObject uiCam;
    public PlayableDirector introTimeline;
    public GameObject loadingText;
    #endregion

    #region Unity Callbacks
    void Start() => StartCoroutine(ARIntroDelay());
    #endregion

    #region My Functions
    public void ARIntroFinished() => StartCoroutine(ARIntroFinishedDelay());

    #region Buttons

    #endregion

    #endregion

    #region Coroutines
    IEnumerator ARIntroDelay()
    {
        fadeBG.Play("FadeIn");
        yield return new WaitForSeconds(0.1f);
        uiCam.SetActive(false);
        introTimeline.Play();
    }

    IEnumerator ARIntroFinishedDelay()
    {
        fadeBG.Play("FadeOut");
        yield return new WaitForSeconds(1f);
        loadingText.SetActive(true);
        SceneManager.LoadScene("OUTRO");
    }
    #endregion
}