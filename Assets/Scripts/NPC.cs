using System.Diagnostics;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NPC : MonoBehaviour
{
    private Text message;
    private bool notHit;
    void Start()
    {
        //Create Text component of a canvas object through unity named "Message"
        message = GameObject.Find("Message").GetComponent<Text>();
        //message.color = Color.white;
        message.text = "";
        notHit=true;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && notHit)
        {
            StartCoroutine(displayText(other));

        }
        //Message to display if main dialogue is done
        else if(other.gameObject.tag == "Player" && !notHit)
        {
            message.text = "Bruh why u so close to me get away";
        }
    }
    IEnumerator displayText(Collider2D other)
    {
        message.text = "Obelia u a bitch";
        other.gameObject.GetComponent<Move2D>().speed = 0;
        //will continue after mouse button is clicked

        //copy this block for every new line of dialouge
        while (!Input.GetButtonDown("Fire1"))
        { //wait for input loop 
       
            yield return null;
        }
        yield return new WaitForEndOfFrame(); //this is essential, it ensures that one input isn't used for all of the messages

       message.text = "jk ily babe";

        while (!Input.GetButtonDown("Fire1"))
        { //wait for input loop 

            yield return null;
        }
        yield return new WaitForEndOfFrame(); 

        message.text = "Well, lets go get some peepeepoopoos";

        //let player move again
        other.gameObject.GetComponent<Move2D>().speed = 6;
        notHit=false;
    }
    
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            message.text = "";
        }
    }
}
