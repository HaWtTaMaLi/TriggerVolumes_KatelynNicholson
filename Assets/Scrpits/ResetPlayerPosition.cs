using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetPlayerPosition : MonoBehaviour
{
    public Transform respawnPoint; 

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(0);
        }
    }
}
