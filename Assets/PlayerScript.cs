using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float movementFactor = 5f;
    public float velocityReductionFactor = 2f;
    private Dictionary<KeyCode, Vector2> keyDirections = new Dictionary<KeyCode, Vector2>();
    // Start is called before the first frame update
    void Start()
    {
        keyDirections.Add(KeyCode.W, new Vector2(0f, 1f));
        keyDirections.Add(KeyCode.A, new Vector2(-1f, 0f));
        keyDirections.Add(KeyCode.S, new Vector2(0f, -1f));
        keyDirections.Add(KeyCode.D, new Vector2(1f, 0f));
    }

    // Update is called once per frame
    void Update()
    {
        handleMovement();
        reduceVelocity();
    }

    void handleMovement()
    {
        Vector2 movement = new Vector2(0f, 0f);
        foreach (KeyCode key in keyDirections.Keys)
        {
            if (Input.GetKey(key))
            {
                movement += keyDirections[key];
            }
        }
        movement *= movementFactor;
        myRigidbody.velocity = movement;
    }

    void reduceVelocity()
    {
        foreach (KeyCode key in keyDirections.Keys)
        {

        }
    }
}
