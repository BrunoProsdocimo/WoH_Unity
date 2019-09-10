using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats_1 : MonoBehaviour
{

    //Floats for each type of parameter characters have
    public float HP;
    public float AP;
    public float STR;
    public float INT;

    /*
    //Classes
    [SerializeField]
    private bool Warrior = false;
    [SerializeField]
    private bool Mage = false;
    */

    private void Start()
    {
        //Random ranges for parameters
        HP = Random.Range(10, 20);
        AP = Random.Range(10, 20);
        STR = Random.Range(3, 10);
        INT = Random.Range(3, 10);

        //To control the parameters and keep them balanced, IF statements 
        if (HP >= 16)
        {
            Debug.Log("AP =" + AP);
            //AP cannot be as high as HP, so lower the value of AP if HP exceeds 16
            AP = Random.Range(10, 14);
        }
        else if (AP >= 16)
        {
            Debug.Log("HP =" + HP);
            //HP cannot be as high as AP, so lower the value of HP if AP exceeds 16
            HP = Random.Range(10, 14);
        }

        if (STR >= 8)
        {
            Debug.Log("INT =" + INT);
            //INT cannot be as high as STR, so lower the value of INT if STR exceeds 8
            INT = Random.Range(3, 6);
        }
        else if (INT >= 8)
        {
            Debug.Log("STR =" + STR);
            //STR cannot be as high as INT, so lower the value of STR if INT exceeds 8
            STR = Random.Range(3, 6);
        }
    }

    /*
    public void WarriorButton()
    {
        Warrior = true;

        STR = (STR * 2);
    }

    public void Classes()
    {
        if (Warrior == true)
        {
            STR = (STR * 2);
        }

        if (Mage == true)
        {
            INT = (INT * 2);
        }
    }
    */
}
