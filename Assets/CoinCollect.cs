using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    public AudioSource audioSource;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ScoreManager.score += 1;
            audioSource.Play();
            Destroy(gameObject, 0.2f);
        }
    }
}