using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alien_Collision : MonoBehaviour
{
    private void Start()
    {
        Game_Manager_Script.Instance.onPlay.AddListener(ActivateAlien);
    }
    private void ActivateAlien()
    {
        gameObject.SetActive(true);
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
    // Check if the collided object has the tag "Obstacle"
    if (other.transform.tag == "Obstacle")
        {
            // Destroy the alien
            gameObject.SetActive(false);
            Game_Manager_Script.Instance.GameOver();
        }
    }
}
