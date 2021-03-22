using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialCometSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject objectToSpawn;
    Vector3 positionToSpawn;

    [SerializeField]
    float timeOut = 2;
    [SerializeField]
    float spawnRadius = 5;

    float checkTimeout = 0;
    float angle;

    const float YAxis = 5;

    // Update is called once per frame
    void Update()
    {
         checkTimeout += Time.deltaTime;

        if (checkTimeout >= timeOut)
        {
            positionToSpawn = CalculatePosition();
            Instantiate(objectToSpawn, positionToSpawn, Quaternion.identity);
            checkTimeout = 0;
        }
    }

    Vector3 CalculatePosition()
    {
        angle = Random.Range(0, 2 * Mathf.PI);

        Vector3 position = new Vector3(Mathf.Cos(angle) * spawnRadius, YAxis, Mathf.Sin(angle) * spawnRadius);
        return position;
    }
}
