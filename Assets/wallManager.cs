using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallManager : MonoBehaviour
{

    public GameObject cube;
    private bool cubeSpawned = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            cubeSpawned = false;
            if (cubeSpawned == false)
            {
                ContactPoint contact = collision.contacts[0];
                Instantiate(cube, contact.point + new Vector3(0f, 0f, -.2f), Quaternion.identity);
                cubeSpawned = true;
            }
        }
        
    }
}
