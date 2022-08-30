using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class collecting_coin : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI coin_counter;
    public int count = 0;

    void Update()
    {
        coin_counter.text = ("" + count);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("coin"))
        {
            Destroy(other.gameObject);
            count++;
        }
    }
}
