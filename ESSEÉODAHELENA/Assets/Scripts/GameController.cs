using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{
    Vector2 posicao;
    public float speed = 2f;

    public GameObject[] hazard;
    public Vector3 spawnValues;
    public int hazardCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;
    

    bool vemDaDireita;


    void Start()
    {
        StartCoroutine(SpawnWaves());
    }

    IEnumerator SpawnWaves()
    {

        yield return new WaitForSeconds(startWait);
        while (true)
        {
            for (int i = 0; i < hazardCount; i++)
            {
                Vector3 spawnPosition = new Vector3(spawnValues.x, Mathf.RoundToInt(Random.Range(-spawnValues.y, spawnValues.y -1)), spawnValues.z);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(hazard[Mathf.RoundToInt(Random.Range(0, 7))], spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);
        }
    }
}