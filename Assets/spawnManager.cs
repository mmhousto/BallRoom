using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{

    public GameObject ball;
    private IEnumerator coroutine;


    // Start is called before the first frame update
    void Start()
    {
        
        coroutine = spawnBall();
        StartCoroutine(coroutine);
    }

    IEnumerator spawnBall()
    {
        var zPos = Random.Range(-8.05f, -3.5f);
        var xPos = Random.Range(3.65f, -3.65f);
        while(true)
        {
            Instantiate(ball, new Vector3(xPos, 0f, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.5f);
            zPos = Random.Range(-8.05f, -3.5f);
            xPos = Random.Range(3.65f, -3.65f);
        }
        
        
    }

    // Update is called once per frame
    void Update()
    {

    }


}
