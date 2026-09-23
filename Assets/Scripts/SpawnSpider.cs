using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnSpider : MonoBehaviour
{
    [SerializeField] GameObject[] Aranha;
    [SerializeField] Transform area;

    void Start()
    {
        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    private IEnumerator Spawn()
    {
        int i = Random.Range(0, Aranha.Length);

        Vector3 spawnPos = new Vector3(Random.Range(-350, 350), 0, Random.Range(-200, 200));

        Instantiate(Aranha[i], spawnPos, Quaternion.identity);

        yield return new WaitForSeconds(4);

        StartCoroutine(Spawn());
    }
}
