using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ClickCounter : MonoBehaviour
{
    public int clickCount = 0;
    public TextMeshProUGUI label;

    public void AddClick()
    {
        clickCount += 1;
        label.text = "Le bouton a été appuyé : \n" + clickCount + " fois.";
        print(clickCount);
    }
}
