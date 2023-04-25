using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LittleShaking : MonoBehaviour
{
    Vector2 startingPos;
    float speed = 5.0f; //how fast it shakes
    float amount = 5.0f; //how much it shakes
    RectTransform go;

    void Awake() {
        go = GetComponent<RectTransform>();
        startingPos.x = go.transform.localPosition.x;
        startingPos.y = go.transform.localPosition.y;

    }

    // Update is called once per frame
    void Update() {

       float shaking_x = startingPos.x + Mathf.Sin(Time.time * speed) * amount;

       float shaking_y = startingPos.y + (Mathf.Sin(Time.time * speed) * amount);

       float shaking_z = GetComponent<RectTransform>().position.z;

       go.transform.localPosition = new Vector3(shaking_x, shaking_y, shaking_z);

    }
}
