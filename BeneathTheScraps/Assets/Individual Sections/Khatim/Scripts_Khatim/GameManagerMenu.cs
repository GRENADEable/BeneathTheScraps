using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagerMenu : MonoBehaviour
{
    #region Public Variables
    public Animator fadeBG;
    public GameObject loadingText;
    public Button[] menuButtons;
    public AudioSource[] audSfx;
    #endregion

    #region Private Variables
    private bool _isFading = false;
    #endregion

    #region Unity Callbacks
    void Start() => fadeBG.Play("FadeIn");

    void Update()
    {
        if (_isFading)
        {
            for (int i = 0; i < audSfx.Length; i++)
                audSfx[i].volume -= Time.deltaTime;
        }
    }
    #endregion

    #region My Functions
    public void OnClick_Start() => StartCoroutine(StartDelay());

    public void OnClick_Exit() => StartCoroutine(QuitDelay());

    void DisableButtons()
    {
        for (int i = 0; i < menuButtons.Length; i++)
            menuButtons[i].interactable = false;
    }
    #endregion

    #region Coroutines
    IEnumerator StartDelay()
    {
        _isFading = true;
        DisableButtons();
        fadeBG.Play("FadeOut");
        yield return new WaitForSeconds(1);
        loadingText.SetActive(true);
        SceneManager.LoadScene("INTRO");
    }

    IEnumerator QuitDelay()
    {
        _isFading = true;
        DisableButtons();
        fadeBG.Play("FadeOut");
        yield return new WaitForSeconds(1);
        Application.Quit();
    }
    #endregion
}