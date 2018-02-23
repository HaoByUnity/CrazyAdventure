using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPlaying : UIBase {

    public override void DoOnEntering()
    {
        //GetComponent<Canvas>().worldCamera = Camera.main;
        gameObject.SetActive(true);
        Camera.main.GetComponent<FollowPlayer>().enabled = true;

    }
    public override void DoOnExiting()
    {
        gameObject.SetActive(false);
        Camera.main.GetComponent<FollowPlayer>().enabled = false;
    }
    public override void DoOnPausing()
    {
    }
    public override void DoOnResuming()
    {
        HeroControl.Instance.ResetPlayer();
    }
}
