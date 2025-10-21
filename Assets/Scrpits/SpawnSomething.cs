using Unity.VisualScripting;
using UnityEngine;

public class SpawnSomething : MonoBehaviour
{

    public GameObject something;
    public AudioSource audioSource;

    private void Start()
    {
        something.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        something.gameObject.SetActive(true);
        audioSource.Play();
    }
}
