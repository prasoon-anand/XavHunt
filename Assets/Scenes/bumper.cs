using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class bumper : MonoBehaviour
{
    public bool isBump1;
    public float speed = 5f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float x = CrossPlatformInputManager.GetAxis("Vertical");
        if (isBump1)
            transform.Translate( CrossPlatformInputManager.GetAxis("Vertical") * speed * Time.deltaTime, 0f,0f);
    }
}
