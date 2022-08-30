using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_2_attach : MonoBehaviour
{
    private GameObject hero;
    private float enemy_speed = 2.5f;

    void Start()
    {
        hero = GameObject.FindGameObjectWithTag("hero");
    }

    void Update()
    {
        float player_distance = Vector3.Distance(transform.position, hero.transform.position);

        if (player_distance <= 10)
        {
            //back & forward
            if (hero.transform.position.z <= transform.position.z)
            {
                transform.Translate(Vector3.back * enemy_speed * Time.deltaTime);
            }
            else
            {
                transform.Translate(Vector3.forward * enemy_speed * Time.deltaTime);
            }

            //left & right
            if (hero.transform.position.x <= transform.position.x)
            {
                transform.Translate(Vector3.left * enemy_speed * Time.deltaTime);
            }
            else
            {
                transform.Translate(Vector3.right * enemy_speed * Time.deltaTime);
            }
        }
    }
}
