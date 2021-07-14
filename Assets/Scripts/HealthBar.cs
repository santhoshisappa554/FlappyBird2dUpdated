using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    Transform bar;
    float size =1.0f;
    // Start is called before the first frame update
    void Start()
    {
        bar = transform.Find("Bar");
    }

   
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)&&size<10.0f)
        {
            size++;
            transform.localScale = new Vector3(size, 1f, 1f);
        }
    }
}
