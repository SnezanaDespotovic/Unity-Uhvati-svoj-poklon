using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VrijednostNovcica : MonoBehaviour
{
    public int vrijednostNovcica=1;
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Player"))
        {
            KrajnjiBrojac.instance.PromjeniVrijednost(vrijednostNovcica);
        }
 
}
}
