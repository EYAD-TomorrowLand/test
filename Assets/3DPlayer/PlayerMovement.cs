using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float playerSpeed;

    //camera
    private Camera cameraReference;

    private Rigidbody rb;

    private float facing;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        cameraReference = Camera.main;
    }

    private void Update()
    {
        float xMovement = Input.GetAxis("Horizontal") * playerSpeed;
        float zMovement = Input.GetAxis("Vertical") * playerSpeed;

        Vector3 movement = new Vector3(xMovement, 0, zMovement);

        rb.velocity = new Vector3(movement.x, rb.velocity.y, movement.z);

        if (movement.x != 0 || movement.z != 0)
            facing = Mathf.Atan2(movement.x, movement.z) * Mathf.Rad2Deg;

        rb.rotation = Quaternion.Euler(0, facing, 0);

        cameraReference.transform.position = new Vector3(transform.position.x, transform.position.y + 7, transform.position.z - 10);
    }

    //to win scene
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("end goal"))
            SceneManager.LoadScene("win_scene");
    }
}