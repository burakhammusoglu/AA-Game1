using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainCircleCode : MonoBehaviour
{
    public GameObject smallCircle;
    GameObject gameadminstrator;
    void Start()
    {
        gameadminstrator = GameObject.FindGameObjectWithTag("gameadminstratortag");
    }

    
    void Update()
    {
        // mouse bastıgında atış yapıyor.
        if (Input.GetButtonDown("Fire1"))
        {
            createCircle();
        }
        
    }
    // kopyalıyoruz circle'ı
    void createCircle()
    {
        Instantiate(smallCircle, transform.position, transform.rotation);
        gameadminstrator.GetComponent<gameadminstrator>().smallCircleText();
    }
}
