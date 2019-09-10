using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class STR_Times2 : MonoBehaviour
{
    //Base stats reference
    public Stats_1 ParameterReference;

    //Button reference
    public Button _MyButton;

    private void Start()
    {

        //Don't really know how this works, copied from the Button Script already in Unity
        Button btn = _MyButton.GetComponent<Button>();

        //This calls the function for the button quen clicked
        btn.onClick.AddListener(STR_Multi);
    }
    //Multiplying the STR value by 2
    public void STR_Multi()
    {
        ParameterReference.STR = (ParameterReference.STR * 2);
    }

}
