using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hero_guns : MonoBehaviour
{
    [SerializeField] private GameObject gun_1, gun_2;
    private bool gun_on = false;

    [SerializeField] private Transform bullet_spawn_point;
    [SerializeField] private Transform bullet_spawn_point_2;
    [SerializeField] private GameObject bulet;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            gun_1.SetActive(true);
            gun_2.SetActive(true);
            gun_on = true;
        }

        else if (Input.GetKeyDown(KeyCode.M))
        {
            gun_1.SetActive(false);
            gun_2.SetActive(false);
            gun_on = false;
        }

        if (Input.GetButtonDown("Fire1") && gun_on == true)
        {
            Instantiate(bulet, bullet_spawn_point.position, transform.rotation);
            Instantiate(bulet, bullet_spawn_point_2.position, transform.rotation);
        }
    }
}
