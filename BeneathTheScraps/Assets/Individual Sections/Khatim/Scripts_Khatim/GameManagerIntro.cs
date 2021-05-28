using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class GameManagerIntro : MonoBehaviour
{
    #region Public Variables
    public Animator fadeBG;
    public PlayableDirector introTimeline;
    #endregion

    #region Private Variables

    #endregion

    #region Unity Callbacks
    void Start() => StartCoroutine(IntroDelay());
    #endregion

    #region My Functions
    public void IntroFinished()
    {

    }

    public void OutroFinished()
    {

    }
    #endregion

    #region Coroutines
    IEnumerator IntroDelay()
    {
        fadeBG.Play("FadeIn");
        yield return new WaitForSeconds(0.9f);
        introTimeline.Play();
    }
    #endregion
}