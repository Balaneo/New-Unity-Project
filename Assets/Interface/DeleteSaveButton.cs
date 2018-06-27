using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DeleteSaveButton : Button
{
    public override void OnSubmit(BaseEventData eventData)
    {
        SaveManager.DeleteSaveData();
        base.OnSubmit(eventData);
    }

    public override void OnPointerClick(PointerEventData eventData)
    {
        SaveManager.DeleteSaveData();
        base.OnPointerClick(eventData);
    }
}
