using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carrot : MonoBehaviour
{
    private SpriteRenderer sr;
    private CircleCollider2D circle;

    public int Score;

    public GameObject collected;

    private AudioSource sound;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        circle = GetComponent<CircleCollider2D>();
        sound = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            sr.enabled = false;
            circle.enabled = false;
            sound.Play();
            collected.SetActive(true);

            Gamecontroller.instance.totalScore += Score;
            Gamecontroller.instance.UpdateScoreText();


            Destroy(gameObject, 0.25f);
        }
    }
}
