using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private float speed;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        speed = 20.0f;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal"); ;
        forwardInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // Si le joueur clique sur la touche "haut", la voiture avance
        if (forwardInput > 0 ) {
            speed = 20.0f;
        }
        // Si le joueur clique sur la touche "bas", la voiture s'arrête
        else if (forwardInput < 0 ) {
            speed = 0;
        }
        
        // Faire tourner la voiture
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
