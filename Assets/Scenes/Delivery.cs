using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32(1, 1, 1, 1);



    int paket = 0;
    [SerializeField] float time = 0.5f;

    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = noPackageColor;

    }
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("carptin");
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        

        if (other.tag=="Pizza" && paket == 0)
        {
            Debug.Log("teslimat alýndý");
            paket = 1;
            spriteRenderer.color = hasPackageColor; 
            Destroy(other.gameObject, time);
        }
        if (other.tag == "Customer" && paket == 1)
        {
            Debug.Log("teslimat verildi");
            paket = 0;
            spriteRenderer.color = noPackageColor;
        }

        if (other.tag == "boost")
        {
            Debug.Log("yeni motor");
        }
    }






}
