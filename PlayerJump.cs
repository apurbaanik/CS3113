using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;

public class PlayerJump : MonoBehaviour
{
    int speed = 10;
    float jumpPower = 12f;
    Rigidbody _rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        // inputs
        float zSpeed = Input.GetAxis("Vertical") * speed;
        float xSpeed = Input.GetAxis("Horizontal") * speed;
        
        _rigidbody.AddForce(new Vector3(xSpeed, 0, zSpeed));

        if(transform.position.y < -10 || transform.position.y > 15) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    
    // Update is called once per frame
    void Update(){
        // Uses the spacebar for the jump feature. 
        if(Input.GetKeyDown(KeyCode.Space))
        {
            // Applying the impulse force instantly with the jump power
            _rigidbody.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
        }
    }
}