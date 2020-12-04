using UnityEngine;
using System.Collections;

public class PlaySound2D : MonoBehaviour
{
    public AudioClip Chirp;
    public bool touched = false;


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && !touched)
        {
            AudioSource.PlayClipAtPoint(Chirp, transform.position);
            touched = true;
        }
    }
}