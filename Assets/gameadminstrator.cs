using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class gameadminstrator : MonoBehaviour
{
    
    GameObject mainCircle;
    GameObject turningCircle;
    public Animator animator;
    public Text turningCircleText;
    public Text one;
    public Text two;
    public Text three;
    public int howSmallCircle;
    bool control = true;
    void Start()

    {
        PlayerPrefs.SetInt("registerLevel", int.Parse(SceneManager.GetActiveScene().name)); /* Playerprefs komutu kayıt alma komutudur.
        2 parametre alıyor 1.si çağıracağımız ismi 2.si kaydettimiz oyun sahnesi.*/ //GetactiveScene bulunduğumuz sahneyi çağırıyoruz.
        // taglerden objelere ulaştık.
        mainCircle = GameObject.FindGameObjectWithTag("maincircletag");
        turningCircle = GameObject.FindGameObjectWithTag("turningcircletag");
        turningCircleText.text = SceneManager.GetActiveScene().name;

        if (howSmallCircle < 2)
        {
            one.text = howSmallCircle + "";
        }
        else if (howSmallCircle < 3)
        {
            one.text = howSmallCircle + "";
            two.text = (howSmallCircle - 1) + "";
        }
        else
        {
            one.text = howSmallCircle + "";
            two.text = (howSmallCircle - 1) + "";
            three.text = (howSmallCircle - 2) + "";
        }
    }
    public void smallCircleText()
    {
        howSmallCircle--;
        if (howSmallCircle < 2)
        {
            one.text = howSmallCircle + "";
            two.text = "";
            three.text = "";
        }
        else if (howSmallCircle < 3)
        {
            one.text = howSmallCircle + "";
            two.text = (howSmallCircle - 1) + "";
            three.text = "";
        }
        else
        {
            one.text = howSmallCircle + "";
            two.text = (howSmallCircle - 1) + "";
            three.text = (howSmallCircle - 2) + "";
        }
        if (howSmallCircle==0)
        {
            StartCoroutine(newLevel());
        }
    }
    IEnumerator newLevel()
    {
        
        mainCircle.GetComponent<mainCircleCode>().enabled = false;
        turningCircle.GetComponent<circleScript>().enabled = false;
        yield return new WaitForSeconds(0.5f);
       
        if (control)
        {
            animator.SetTrigger("newlevel");
            yield return new WaitForSeconds(1);
            SceneManager.LoadScene(int.Parse(SceneManager.GetActiveScene().name) + 1);
        }

    }
    public void gameOver()
    {
        StartCoroutine(callMethod());
    }
    IEnumerator callMethod()
    {
        // circlelar üst üste geldiği zaman oyunu durdurduk.
        
        mainCircle.GetComponent<mainCircleCode>().enabled = false;
        turningCircle.GetComponent<circleScript>().enabled = false;
        animator.SetTrigger("gameover");
        control = false;
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("anaMenü");
    }
    
}
