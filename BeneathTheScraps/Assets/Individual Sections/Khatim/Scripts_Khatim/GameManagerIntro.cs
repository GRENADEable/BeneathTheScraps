using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class GameManagerIntro : MonoBehaviour
{
    #region Public Variables
    public Animator fadeBG;
    public PlayableDirector introTimeline;
    public GameObject loadingText;
    public Button uIButtons;
    #endregion

    #region Unity Callbacks
    void Start() => StartCoroutine(IntroDelay());
    #endregion

    #region My Functions
    public void IntroFinished() => StartCoroutine(IntroFinishedDelay());

    public void OnClick_Exit() => StartCoroutine(ExitDelay());

    void DisableButtons() => uIButtons.interactable = false;
    #endregion

    #region Coroutines
    IEnumerator IntroDelay()
    {
        fadeBG.Play("FadeIn");
        yield return new WaitForSeconds(0.1f);
        introTimeline.Play();
    }

    IEnumerator IntroFinishedDelay()
    {
        DisableButtons();
        fadeBG.Play("FadeOut");
        yield return new WaitForSeconds(1f);
        loadingText.SetActive(true);
        SceneManager.LoadScene("AR_FINAL");
    }

    IEnumerator ExitDelay()
    {
        DisableButtons();
        fadeBG.Play("FadeOut");
        yield return new WaitForSeconds(1f);
        loadingText.SetActive(true);
        SceneManager.LoadScene("MENU_V2");
    }
    #endregion
}