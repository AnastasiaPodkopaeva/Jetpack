using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeCount : MonoBehaviour
{
    public Image[] lives;
    public int livesRemaining;
    private float myTimer;
    private uint acorn = 0;

    public GameObject[] availableObjects;
    public List<GameObject> objects;

    public float objectsMinDistance = 5.0f;
    public float objectsMaxDistance = 10.0f;

    public float objectsMinY = -1.4f;
    public float objectsMaxY = 1.4f;

    public float objectsMinRotation = -45.0f;
    public float objectsMaxRotation = 45.0f;

    public Text acornCollectedLabel;
    public AudioSource Hit;
    public AudioSource AcornCollect;
    //  private BoxCollider2D bc;

    public void LoseLife()
    {
        if (livesRemaining == 0)
            return;
        //decrease the value of livesRemaining
        livesRemaining--;
        lives[livesRemaining].enabled = false;
        //if we run out of lives we lose the game
        if (livesRemaining == 0)
        {
            FindObjectOfType<CharacterController2D>().Die();
           
        }
    }

    private void Start()
    {
        myTimer = 0;
    }

    void Update()
    {
        myTimer -= Time.deltaTime;
    }

    void CollectAcorn(Collider2D acornCollider)
    {
        acorn++;
        acornCollectedLabel.text = acorn.ToString();
        Destroy(acornCollider.gameObject);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("acorn"))
        {
            CollectAcorn(collider);
            AcornCollect.Play();
        }
       
        else if (myTimer<=0) HitByLaser(collider);
    }

    void HitByLaser(Collider2D laserCollider)
    {
        myTimer = 1f;
        Hit.Play();
        LoseLife();
    }

}
