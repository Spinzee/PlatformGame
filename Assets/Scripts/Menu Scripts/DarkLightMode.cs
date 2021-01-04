using UnityEngine;
using UnityEngine.UI;

public class DarkLightMode : MonoBehaviour
{
    bool isDark;
    Image optionsBackground;

    void Start()
    {
        isDark = false;
        optionsBackground = GetComponent<Image>();
    }

    public void SwitchColours()
    { 
        if (isDark)
        {
            optionsBackground.color = new Color32(219, 149, 0, 179);
            isDark = false; 
        }
        else
        {
            optionsBackground.color = new Color(102, 79, 22, 179);
            isDark = true;
        }
    }
}
