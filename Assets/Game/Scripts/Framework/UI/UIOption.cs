using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class UIOption : UIBase
{
    public override string Name
    {
        get
        {
            return "UIOption";
        }
    }
    public override void DoOnEntering()
    {
        GetComponent<Canvas>().worldCamera = Camera.main;
        //gameObject.SetActive(true);
        canvasGroup.interactable = true;
        canvasGroup.DOFade(1f, 0.5f);

    }
    public override void DoOnExiting()
    {
        //gameObject.SetActive(false);
        canvasGroup.interactable = false;
        canvasGroup.DOFade(0f, 0.5f);

    }
    public override void DoOnPausing()
    {
        canvasGroup.interactable = false;
    }
    public override void DoOnResuming()
    {
        canvasGroup.interactable = true;
    }
    public void GoToStart()
    {
        UIManager.Instance.PopUIPanel();
    }
    public void SetBGMMute(bool mute)
    {
        SoundManager.Instance.Mute = mute;
    }
}
