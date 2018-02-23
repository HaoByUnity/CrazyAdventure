using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIBase : MonoBehaviour
{
    protected CanvasGroup canvasGroup;
    protected virtual void Awake()
    {
        canvasGroup = GetComponent<CanvasGroup>();
    }
    public virtual string Name { get; set; }
    public virtual void DoOnEntering()
    { }
    public virtual void DoOnPausing()
    { }
    public virtual void DoOnResuming()
    { }
    public virtual void DoOnExiting()
    { }
}
