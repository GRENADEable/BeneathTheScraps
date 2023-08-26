using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class GameManagerOutro : MonoBehaviour
{
    #region Public Variables
    public Animator fadeBG;
    public PlayableDirector outroTimeline;
    public GameObject loadingText;
    public Button uIButtons;
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

    public void OnClick_Exit() => StartCoroutine(ExitDelay());

    void DisableButtons() => uIButtons.interactable = false;
    #endregion

    #region Coroutines
    IEnumerator EndOutroFinishedDelay()
    {
        DisableButtons();
        fadeBG.Play("FadeOut");
        yield return new WaitForSeconds(1f);
        //loadingText.SetActive(true);
        //SceneManager.LoadScene("MENU_V2");
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