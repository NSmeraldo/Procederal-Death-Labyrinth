using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EXPmanager : MonoBehaviour
{
    public float exp;
    public float maxEXP;
    public int Level = 1;


    public GameObject expBarUI;
    public Slider slider;
    private void Start()
    {
        expBarUI = GameObject.FindGameObjectWithTag("EXP");
        slider = GameObject.FindGameObjectWithTag("EXP").GetComponent<Slider>();
        maxEXP = 100f;
        slider.value = CalculateEXP();
    }

    private void Update()
    {
        slider.value = CalculateEXP();

        if (exp <= 0)
        {
            expBarUI.SetActive(false);
        }
        else
        {
            expBarUI.SetActive(true);
        }
        if(exp == maxEXP)
        {
            exp = 0;
            maxEXP = maxEXP + 20 * Level;
            Level++;
        }

    }

    float CalculateEXP()
    {
        return exp / maxEXP;
    }
}