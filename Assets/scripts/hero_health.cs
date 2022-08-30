using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class hero_health : MonoBehaviour
{
    [SerializeField] private Image health_meter;
    private bool health_load = true;

    void Start()
    {
        health_meter.fillAmount = 0.001f;
    }

    void Update()
    {
        //just for loading health bar
        if (health_load == true)
        {
            health_meter.fillAmount += 0.5f * Time.deltaTime;

            if (health_meter.fillAmount >= 1)
                health_load = false;
        }

        //check player health
        if (health_meter.fillAmount <= 0)
            SceneManager.LoadScene("lose_scene");
    }

    private void OnCollisionEnter(Collision collision)
    {
        //delete enemy2
        if (collision.gameObject.CompareTag("enemy"))// ||
            //collision.gameObject.CompareTag("enemy2"))
        {
            health_meter.fillAmount -= 10 * Time.deltaTime;
        }

        if (collision.gameObject.CompareTag("hazard"))
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
