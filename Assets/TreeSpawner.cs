using UnityEngine;

public class TreeSpawner : MonoBehaviour
{
    public GameObject treePrefab;
    public int treeCount = 20;
    public float areaSize = 40f;

    void Start()
    {
        for (int i = 0; i < treeCount; i++)
        {
            Vector3 pos = new Vector3(
                Random.Range(-areaSize, areaSize),
                0,
                Random.Range(-areaSize, areaSize)
            );

            Instantiate(treePrefab, pos, Quaternion.identity);
        }
    }
}