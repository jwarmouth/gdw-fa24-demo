using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public GameObject projectilePrefab;

    void Start()
    {
        
    }

    void Update()
    {
        // Move Player
        float hInput = Input.GetAxis("Horizontal");
        float vInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * speed * Time.deltaTime * hInput);
        transform.Translate(Vector3.up * speed * Time.deltaTime * vInput);

        // Fire projectile
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, transform.rotation);
        }
    }
}
