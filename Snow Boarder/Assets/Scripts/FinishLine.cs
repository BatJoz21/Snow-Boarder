using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] private string levelName;
    [SerializeField] private float nextLevelTime = 0.5f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Invoke("NextLevel", nextLevelTime);
        }
        
        void NextLevel()
        {
            SceneManager.LoadScene(levelName);
        }
    }
}
