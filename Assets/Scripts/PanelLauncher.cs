using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelLauncher : MonoBehaviour
{
    public GameObject[] panels;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void moveToPanel(GameObject panel) {
        foreach (var singlePanel in panels) {
            singlePanel.gameObject.SetActive(false);
        }

        panel.SetActive(true);
    }
}
