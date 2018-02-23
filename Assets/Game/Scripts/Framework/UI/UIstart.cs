using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIstart : UIBase
{
    public override string Name
    {
        get
        {
            return "UIStart";
        }
    }
    public override void DoOnEntering()
    {
        GetComponent<Canvas>().worldCamera = Camera.main;
        SoundManager.Instance.PlayBGM("Audio_bgm_1");
        Debug.Log("Play");
        canvasGroup.alpha = 1;
    }
    public override void DoOnExiting()
    {
        base.DoOnExiting();
        canvasGroup.alpha = 0;

    }
    public override void DoOnPausing()
    {
        gameObject.SetActive(false);
        canvasGroup.alpha = 0;

        // canvasGroup.interactable = false;
    }
    public override void DoOnResuming()
    {
         gameObject.SetActive(true);
        canvasGroup.alpha = 1;

        //canvasGroup.interactable = true;
    }
    public void GoToOption()
    {
        UIManager.Instance.PushUIPanel("UIOption");

    }
    public void GoToPlaying()
    {
        UIManager.Instance.PushUIPanel("Playing");
    }
}
