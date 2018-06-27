using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class LoadButton : Button
{
    public override void OnSubmit(BaseEventData eventData)
    {
        SaveManager.Load();
        base.OnSubmit(eventData);
    }

    public override void OnPointerClick(PointerEventData eventData)
    {
        SaveManager.Load();
        base.OnPointerClick(eventData);
    }
}
