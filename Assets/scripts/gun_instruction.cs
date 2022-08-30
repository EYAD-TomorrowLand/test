using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class gun_instruction : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI our_text;

    void Start()
    {
        our_text.text = ("press N for cannons");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
            our_text.text = ("press M to LOWER the guns");

        if (Input.GetKeyDown(KeyCode.M))
            our_text.text = ("press N for the guns");
    }
}
