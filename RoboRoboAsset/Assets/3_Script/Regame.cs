using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Regame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RRegame()
    {
        Time.timeScale = 1.0f;
        Application.LoadLevel("1_play");
    }
}
