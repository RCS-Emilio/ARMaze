using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallClass : MonoBehaviour
{
    public int remainingKey;
    public AudioSource goalSound;
    public AudioSource keySound;
    public GameObject goal;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "key") {
            Destroy(other.gameObject);
            keySound.Play();
            remainingKey--;
            if(remainingKey == 0) 
                goal.GetComponent<Renderer>().material.color = Color.green;
        }

        if (other.tag == "goal" && remainingKey == 0) { 
            goalSound.Play();
            SceneManager.LoadScene("MainMenu");
        }
    }
}
