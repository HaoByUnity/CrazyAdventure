using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class UILose : UIBase {
    public Text txt_IQ;
    public override void DoOnEntering()
    {
        GetComponent<Canvas>().worldCamera = Camera.main;
        transform.GetChild(0).DOLocalMoveY(0, 1);
        int IQ = Random.Range(-200, 500);
        txt_IQ.text = IQ.ToString();
    }
    public override void DoOnExiting()
    {
        canvasGroup.alpha = 0;
    }
    public override void DoOnPausing()
    {
        canvasGroup.alpha = 0;
    }
    public override void DoOnResuming()
    {
        int IQ = Random.Range(-200, 500);
        txt_IQ.text = IQ.ToString();
        canvasGroup.alpha = 1;

    }
    public void OnRePlayClick()
    {
        UIManager.Instance.PopUIPanel();
    }
}
