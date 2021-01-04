using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FontControl : MonoBehaviour
{
    [SerializeField] List<Text> Fonts;
    [SerializeField] GameObject red;
    [SerializeField] GameObject green;
    [SerializeField] GameObject blue;
    [SerializeField] GameObject dropdownObject;

    Dropdown dropdown;

    TextMeshProUGUI redValue;
    TextMeshProUGUI blueValue;
    TextMeshProUGUI greenValue;

    int textResize;

    void Awake()
    {
        dropdown = dropdownObject.GetComponent<Dropdown>();
        dropdown.value = 2;

        redValue = red.GetComponent<TextMeshProUGUI>();
        blueValue = blue.GetComponent<TextMeshProUGUI>();
        greenValue = green.GetComponent<TextMeshProUGUI>();
    }
        
    public void OnChangeDropdown()
    {      
        switch (dropdown.value)
        {
            case 0:
                textResize = 9;
                break;
            case 1:
                textResize = 10;
                break;
            case 2:
                textResize = 20;
                break;
            case 3:
                textResize = 25;
                break;
            case 4:
                textResize = 30;
                break;
        }

        foreach (var text in Fonts)
        {
            text.fontSize = textResize;
        }
    }

    public void OnChangeColourPicker()
    {
        if (redValue != null && blueValue != null && greenValue != null)
        {
            foreach (var text in Fonts)
            {
                text.color = new Color32(
                    byte.Parse(redValue.text),
                    byte.Parse(greenValue.text),
                    byte.Parse(blueValue.text), 255);                    
            }
        }
    }
}
