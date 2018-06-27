using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Button entry for weapon display. 

public class ProfileButton : Button
{
    private Text textTarget;

    public void SetProfileInfo(InvestigatorsSave investigator)
    {
        textTarget = this.GetComponentInChildren<Text>();

        if (textTarget)
        {
            textTarget.text = investigator.investigatorName;
        }
    }

    public void SetProfileInfo(string textString)
    {
        textTarget = this.GetComponentInChildren<Text>();

        if (textTarget)
        {
            textTarget.text = textString;
        }
    }
}
