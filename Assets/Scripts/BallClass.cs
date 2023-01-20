using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallClass : MonoBehaviour
{
    public static bool hasKey = false;
    public AudioSource goalSound;
    public AudioSource keySound;
    public GameObject goal;
    Renderer goalRender;
    // Start is called before the first frame update
    void Start()
    {
        Renderer goalRender = goal.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("key")) {
            Destroy(other.gameObject);
            keySound.Play();
            hasKey = true;
            goalRender.material.color = Color.green;
        }

        if (other.CompareTag("goal")) { 
            goalSound.Play();
        }
    }
}
