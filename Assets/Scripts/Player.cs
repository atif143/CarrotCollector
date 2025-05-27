using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;


public class Player : MonoBehaviour
{
    public FixedJoystick joystick;
    public float moveSpeed;

    float hInput, vInput;
    int Score = 0;
    public GameObject winText;
    public int winScore;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = Score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
         void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Carrot")
            {
                Score++;
                scoreText.text = "Score: " + +1;
            } }
    }

    private void FixedUpdate()
    {
        hInput = joystick.Horizontal*moveSpeed;
        vInput = joystick.Vertical*moveSpeed;

        transform.Translate(hInput, vInput, 0);

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag =="Carrot") 
        {
            Destroy(collision.gameObject);

            if (Score >= winScore)
            {
                winText.SetActive(true);
            }
            
        }
    }
}
