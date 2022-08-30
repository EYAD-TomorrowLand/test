using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class bullet_setting : MonoBehaviour
{
    private float bullet_speed = 1000;
    private Rigidbody rb;
    [SerializeField] GameObject coin;
    private GameObject replace;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * bullet_speed);
    }

    void Update()
    {
        Invoke("delete", 1);
    }

    private void delete()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("enemy"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);

            replace = PrefabUtility.InstantiatePrefab(coin) as GameObject;
            replace.transform.position = other.gameObject.transform.position;
        }
    }
}
