using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private Animation thisAnimation;

    private float speed = 5f;

    public int score;
    public Text ScoreTxt;

    public Rigidbody rb;
    void Start()
    {
        thisAnimation = GetComponent<Animation>();
        thisAnimation["Flap_Legacy"].speed = 3;

        rb.GetComponent<Rigidbody>();
    }

    void Update()
    {
        score = Obstacle.Score;
        ScoreTxt.text = "Score: " + score;

        if(Input.GetKeyDown(KeyCode.Space))
        {
            thisAnimation.Play();
            rb.velocity = Vector2.up * speed;
        }
        
        if(transform.position.y < -4)
        {
            //Gamelose
            SceneManager.LoadScene("GameLose");
        }
        if (transform.position.y >= 4)
        {
            speed = 0f;
        }
        else
        {
            speed = 5f;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Obstacle")
        {
            //Gamelose
            SceneManager.LoadScene("GameLose");
        }
    }
}
