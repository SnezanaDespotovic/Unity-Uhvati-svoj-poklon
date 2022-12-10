using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControlPahulja : MonoBehaviour
{
    public GameObject pahulja1, pahulja2, pahulja3, youWON, statistika, pb, statistikaPahulja, player;
    public static int pahulja;
    void Start()
    {
        pahulja=3;
        pahulja1.gameObject.SetActive(false);
        pahulja2.gameObject.SetActive(false);
        pahulja3.gameObject.SetActive(false);
        pb.gameObject.SetActive(true);
        statistika.gameObject.SetActive(true);
        statistikaPahulja.gameObject.SetActive(true);
        player.gameObject.SetActive(true);
        youWON.gameObject.SetActive(false);
        
    }

    void Update()
    {
        if(pahulja<=0)
        pahulja=0;
        switch (pahulja)
        {
           case 3:
            pahulja1.gameObject.SetActive(false);
            pahulja2.gameObject.SetActive(false);
            pahulja3.gameObject.SetActive(false);
            break;
           case 2:
            pahulja1.gameObject.SetActive(true);
            pahulja2.gameObject.SetActive(false);
            pahulja3.gameObject.SetActive(false);
            break;
            case 1:
            pahulja1.gameObject.SetActive(true);
            pahulja2.gameObject.SetActive(true);
            pahulja3.gameObject.SetActive(false);
            break;
            case 0:
            pahulja1.gameObject.SetActive(true);
            pahulja2.gameObject.SetActive(true);
            pahulja3.gameObject.SetActive(true);
            statistika.gameObject.SetActive(false);
            statistikaPahulja.gameObject.SetActive(false);
            player.gameObject.SetActive(false);
            pb.gameObject.SetActive(false);
            youWON.gameObject.SetActive(true);
                      
            
            //Time.timeScale=0;
            break;
            Start();

        }
    }
}
        
