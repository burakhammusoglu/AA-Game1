using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circleScript : MonoBehaviour
{
    // çemberin dönüşünü ayarlıyoruz.
    public int hiz;
    void Update()
    {
        transform.Rotate(0, 0, hiz * Time.deltaTime);
        /* Deltatime : unityde çalıştırdığımız fonksiyonlar bilgisayarın hızına bağlıdır.O yüzden fonksiyonlarımız bilgisayarımız hızlı
         * çalışıyorsa hızlı , yavaş çalışıyorsa yavaş çalışır.deltaTime fonksiyonu zamana bağlı çalıştığı için bu hataları önler.*/

    }
}
