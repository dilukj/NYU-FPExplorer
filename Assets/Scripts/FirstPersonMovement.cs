using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FirstPersonMovement : MonoBehaviour
{
    // Player's movement paramss
    public Vector3 direction;
    public float speed;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    // On player move event handler
    public void OnPlayerMove(InputValue value)
    {
        Vector2 inputVector = value.Get<Vector2>();

        // move in the XZ plane
        direction.x = inputVector.x;
        direction.z = inputVector.y;
    }
}
