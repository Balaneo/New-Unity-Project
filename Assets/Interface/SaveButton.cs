using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SaveButton : Button
{
    public override void OnSubmit(BaseEventData eventData)
    {
        SaveManager.Save();
        base.OnSubmit(eventData);
    }

    public override void OnPointerClick(PointerEventData eventData)
    {
        SaveManager.Save();
        base.OnPointerClick(eventData);
    }
}
