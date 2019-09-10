using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Stats_Display : MonoBehaviour
{
    public Stats_1 DisplayStats;


    //The text needs to be specified
    public Text _UI_HP;
    public Text _UI_AP;
    public Text _UI_STR;
    public Text _UI_INT;

    // Update is called once per frame
    void Update()
    {

        _UI_HP.text = "HP : " + DisplayStats.HP;
        
        _UI_AP.text = "AP : " + DisplayStats.AP;

        _UI_STR.text = "STR : " + DisplayStats.STR;

        _UI_INT.text = "INT : " + DisplayStats.INT;
        
    }
}
