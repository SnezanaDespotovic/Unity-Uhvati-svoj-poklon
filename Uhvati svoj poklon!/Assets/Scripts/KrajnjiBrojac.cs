using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KrajnjiBrojac : MonoBehaviour
{
    public static KrajnjiBrojac instance;
    public TextMeshProUGUI text;
    int ukupno;
    // Start is called before the first frame update
    void Start()
    {
        if(instance==null)
        {
            instance = this;
        }
    }
    public void PromjeniVrijednost(int vrijednostNovcica)
    {
        ukupno+=vrijednostNovcica;
        text.text=ukupno.ToString();
    }

}
