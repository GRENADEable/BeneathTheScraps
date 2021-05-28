using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class GameManagerAR : MonoBehaviour
{
    #region Public Variables
    //public GameObject uiCam;
    public GameObject mainCam;
    public GameObject[] fpsCam;
    public PlayableDirector introTimeline;
    public GameObject loadingText;
    public Animator fadeBG;
    public Animator[] beltAnim;
    #endregion

    #region Unity Callbacks
    void Start() => StartCoroutine(ARIntroDelay());
    #endregion

    #region My Functions
    public void ARIntroFinished() => StartCoroutine(ARIntroFinishedDelay());

    public void LeverPressed()
    {
        for (int i = 0; i < beltAnim.Length; i++)
            beltAnim[i].Play("BeltAnim");
    }

    #region Buttons
    public void OnClick_SwitchCam()
    {
        mainCam.SetActive(!mainCam.activeSelf);

        for (int i = 0; i < fpsCam.Length; i++)
            fpsCam[i].SetActive(!fpsCam[i].activeSelf);
    }
    #endregion

    #endregion

    #region Coroutines
    IEnumerator ARIntroDelay()
    {
        fadeBG.Play("FadeIn");
        yield return new WaitForSeconds(0.1f);
        //uiCam.SetActive(false);
        //mainCam.SetActive(true);
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