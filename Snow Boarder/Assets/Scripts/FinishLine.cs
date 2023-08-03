using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] private string levelName;
    [SerializeField] private float nextLevelTime = 0.5f;
    [SerializeField] private ParticleSystem finishEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            finishEffect.Play();
            Invoke("NextLevel", nextLevelTime);
        }
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(levelName);
    }
}
