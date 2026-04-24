using UnityEngine;

public class CoinRotate : MonoBehaviour
{
    public float rotateSpeed = 100f;
    public float floatHeight = 0.3f;
    public float floatSpeed = 2f;

    Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);

        float newY = startPos.y + Mathf.Sin(Time.time * floatSpeed) * floatHeight;
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}