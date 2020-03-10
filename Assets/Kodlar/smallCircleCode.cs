using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smallCircleCode : MonoBehaviour
{
    Rigidbody2D fizik;
    public float hiz;
    bool actionControl = false;
    GameObject gameadminstrator;
    void Start()
    {
        fizik= GetComponent<Rigidbody2D>();
        gameadminstrator = GameObject.FindGameObjectWithTag("gameadminstratortag");
        
    }

    
    void FixedUpdate() // fixedUpdate komutumuzla fizik işlemlerini bu metod ile hallediyoruz.
    {
        if (!actionControl)
        {
            fizik.MovePosition(fizik.position + Vector2.up * hiz* Time.deltaTime);
        }

    }
    private void OnTriggerEnter2D(Collider2D col) //Ontrigger metodumuzla cisimlerin üst üste gelip gelmediğini kontrol ediyoruz.

    {
        if (col.tag == "turningcircletag")
        {

            transform.SetParent(col.transform);
            actionControl = true;
           
        }
        if (col.tag == "smallcircletag")
        {
            
            gameadminstrator.GetComponent<gameadminstrator>().gameOver();
        }
        
    }
}
