using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    int speed = 10;
    Rigidbody _rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // inputs
        float zSpeed = Input.GetAxis("Vertical") * speed;
        float xSpeed = Input.GetAxis("Horizontal") * speed;
        
        _rigidbody.AddForce(new Vector3(xSpeed, 0, zSpeed));

        if(transform.position.y < -10) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        
    }
}