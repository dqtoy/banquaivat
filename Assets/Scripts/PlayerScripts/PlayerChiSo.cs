using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerChiSo : MonoBehaviour
{

    [SerializeField]
    private Image HP, MN;

    public void Display_HealthStats(float value)
    {
        if (value < 0)
        {
            SceneManager.LoadScene("EndGame");
        }

        value /= 100f;

        HP.fillAmount = value;

    }

    public void Display_StaminaStats(float value)
    {

        value /= 100f;

        MN.fillAmount = value;


    }


} // class





























