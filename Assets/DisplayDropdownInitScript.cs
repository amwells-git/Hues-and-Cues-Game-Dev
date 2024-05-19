using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayDropdownInitScript : MonoBehaviour
{
    [SerializeField] public TMP_Dropdown dropdown;

    public void Start()
    {
        AddDisplay();
    }

    public void AddDisplay()
    {
        for (int i = 0; i < Display.displays.Length; i++)
        {
            dropdown.options.Add(new TMP_Dropdown.OptionData("Monitor " + (i + 1), null));
        }
    }
}
