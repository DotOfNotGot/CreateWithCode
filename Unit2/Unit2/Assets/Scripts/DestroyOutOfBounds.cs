using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    private float topBound = 25.0f;
    private float lowerBound = -10.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Checks if game object has gone outside top bound and destroys it if it has.
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        // Checks if game object has gone outside lower bound and destroys it if it has. Also displays a game over message.
        else if (transform.position.z < lowerBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
