using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokloni : MonoBehaviour
{
    [SerializeField] GameObject[] poklonPrefab;
    [SerializeField] float secondSpawn = 0.5f;
    [SerializeField] float minTras;
    [SerializeField] float maxTras;
    void Start()
    {
        StartCoroutine(FirstSpawn());
    }
    IEnumerator FirstSpawn()
    {
        while (true)

        {
            var wanted = Random.Range(minTras, maxTras);
            var position= new Vector2(wanted, transform.position.y);
            GameObject gameObject = Instantiate(poklonPrefab[Random.Range(0, poklonPrefab.Length)],
            position, Quaternion.identity);  
            yield return new WaitForSeconds(secondSpawn);
            Destroy(gameObject, 5f);  
        }
    }

    
}
