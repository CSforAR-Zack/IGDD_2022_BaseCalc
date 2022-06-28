using System;
using TMPro;
using UnityEngine;

public class Converter : MonoBehaviour
{
    public TMP_InputField inputValue = null;
    public TMP_Dropdown baseSelection = null;
    public TMP_Text binText = null;
    public TMP_Text octText = null;
    public TMP_Text decText = null;
    public TMP_Text hexText = null;

    string value = "";
    long number = 0;

    public void ConvertValue()
    {
        value = inputValue.text;

        if(value == "")
        {
            return;
        }

        if(baseSelection.value == 0)
        {
            number = Convert.ToInt64(value, 2);
        }

        binText.text = Convert.ToString(number, 2);
        octText.text = Convert.ToString(number, 8);
        decText.text = Convert.ToString(number, 10);
        hexText.text = Convert.ToString(number, 16).ToUpper();
    }
}
