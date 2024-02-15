using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float height = 10; 
    // Start is called before the first frame update
    void Start()
    {
        spawnupdte();

    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnupdte();
                timer = 0;
        }
    }
    void spawnupdte()
    {
        float lpoint = transform.position.y - height;
        float hpoint = transform.position.y + height;

        Instantiate(pipe, new Vector3(transform.position.x , Random.Range(lpoint,hpoint)), transform.rotation);
    }
}
