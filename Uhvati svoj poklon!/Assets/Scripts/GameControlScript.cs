using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControlScript : MonoBehaviour
{
    public GameObject srce1, srce2, srce3, gameOver, statistika, pb, pahuljice, igrac;
    public static int healthh;
    void Start()
    {
        healthh=3;
        srce1.gameObject.SetActive(true);
        srce2.gameObject.SetActive(true);
        srce3.gameObject.SetActive(true);
        pb.gameObject.SetActive(true);
        igrac.gameObject.SetActive(true);
        pahuljice.gameObject.SetActive(true);
        statistika.gameObject.SetActive(true);
        gameOver.gameObject.SetActive(false);
    }

    void Update()
    {
        if(healthh>3)
        healthh=3;
        switch (healthh)
        {
           case 3:
            srce1.gameObject.SetActive(true);
            srce2.gameObject.SetActive(true);
            srce3.gameObject.SetActive(true);
            break;
           case 2:
            srce1.gameObject.SetActive(true);
            srce2.gameObject.SetActive(true);
            srce3.gameObject.SetActive(false);
            break;
            case 1:
            srce1.gameObject.SetActive(true);
            srce2.gameObject.SetActive(false);
            srce3.gameObject.SetActive(false);
            break;
            case 0:
            srce1.gameObject.SetActive(false);
            srce2.gameObject.SetActive(false);
            srce3.gameObject.SetActive(false);
            statistika.gameObject.SetActive(false);
            pb.gameObject.SetActive(false);
            igrac.gameObject.SetActive(false);
            pahuljice.gameObject.SetActive(false);
            gameOver.gameObject.SetActive(true);
            
            
            //Time.timeScale=0;
            break;
            Start();

        }
        
  
    
  

    }
}
