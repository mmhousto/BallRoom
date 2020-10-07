using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballManager : MonoBehaviour
{

    private const float speed = 10f;
    
    // Start is called before the first frame update
    void Start()
    {
        var rb = GetComponent<Rigidbody>();
        var rand = Random.Range(-5.0f, 5.0f);
        var rand2 = Random.Range(-5.0f, 5.0f);
        rb.velocity = new Vector3(rand, 0, rand2);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y >= 1.0f || transform.position.y <= -10)
        {
            Destroy(gameObject);
        }
    }
}
