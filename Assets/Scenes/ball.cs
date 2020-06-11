using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using TMPro;
public class ball : MonoBehaviour
{
    public float speed = 2f;
    public int score = 0;
    public TextMeshProUGUI text;
    // Use this for initialization
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (CrossPlatformInputManager.GetButtonDown("Jump"))
        {
            float sx = Random.Range(0, 2) == 0 ? -1 : 1;
            float sy = Random.Range(0, 2) == 0 ? -1 : 1;
            GetComponent<Rigidbody>().velocity = new Vector3(speed * sx, 0f, speed * sy);
        }
    
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "sidewall")
            score++;
            text.text = score.ToString(); 
    }
}
