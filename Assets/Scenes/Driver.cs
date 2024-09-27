using UnityEngine;
using  System.Collections;
using  System.Collections.Generic;

public class Driver : MonoBehaviour
{

    [SerializeField] float steerSpeed = 1f;
    [SerializeField] float moveSpeed = 8f;

    [SerializeField] float boostSpeed = 12f;
    //serialize field yapýnca unity arayüzünden
    //deðiþken deðeri ile oynayabilirsin


    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;//bilgisayarlarýn çalýþma
                                                                                      //hýzýndan baðýmsýz bir oyun deneyimi için
                                                                                      //TÝme.deltaTime kullanýlýr

        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Rotate(0,0, -steerAmount);
        transform.Translate(0, moveAmount, 0);

        

    }

    void OnTriggerEnter2D(Collider2D other)
    {


        if (other.tag == "Boost")
        {
            Debug.Log("yeni motor!");
            moveSpeed = boostSpeed;
        }

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (moveSpeed > 4)
        {
            moveSpeed -= 1f ; 
        }
        

        Debug.Log("hasar aldýn!");


    }
}
