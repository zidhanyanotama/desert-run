using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
   public int health;
   public GameObject[] healthUI;

   void TakeDamage()
   {
    health--;
    if(health <=0)
    {
        health=0;
        GoalManager.singleton.PlayerLose();
    }

    healthUI[health].SetActive(false);
   }

   public AudioSource suaraCoin;
   public AudioSource suaraKey;
   public AudioSource suaraWin;


   

   private void OnTriggerEnter2D(Collider2D collison)
   {
    if(collison.CompareTag("Enemy"))
    {
        TakeDamage();
    }

    else if (collison.CompareTag("Spike"))
    {
        GoalManager.singleton.PlayerLose();
        foreach (GameObject Ui in healthUI)
        {
            Ui.SetActive(false);
        }
    }

    else if(collison.CompareTag("GoldCoin"))
    {
        GoalManager.singleton.CoinColected();
        Destroy(collison.gameObject);
        suaraCoin.Play();
    }

    else if (collison.CompareTag("Key"))
    {
        GoalManager.singleton.GetKey();
        Destroy(collison.gameObject);
        suaraKey.Play();
    }

    else if(collison.CompareTag("Goal"))
    {
        GoalManager.singleton.LevelCompleted();
        suaraWin.Play();
    }

   }
}
