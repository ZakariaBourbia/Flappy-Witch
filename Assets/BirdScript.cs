using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class BirdScript : MonoBehaviour
{
    public float flapstrenght;
    public Rigidbody2D myrigidbody2d;
    public Score score;
    public bool birdisalive = true;
    public AudioSource jump;

    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.FindGameObjectWithTag("logic").GetComponent<Score>();

    }

    // Update is called once per frame
    void Update()
    {
        if( Input.GetKeyDown(KeyCode.Space) == true && birdisalive )
        { myrigidbody2d.velocity = Vector2.up * flapstrenght;
            jump.Play();
                
                }
            
        if (transform.position.y > 13 || transform.position.y < -14 )
        {
            score.gameOver();
            birdisalive = false;
        }
            
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        score.gameOver();
        birdisalive = false;
    }
}
