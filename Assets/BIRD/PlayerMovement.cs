using UnityEngine;
using UnityEngine.InputSystem; 
using TMPro; // FIX 1: Hapus UnityEngine.UI dan ganti dengan TMPro

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D Rb;
    public float jumpForce;
    
    // FIX 2: Ubah dari 'Text' menjadi 'TextMeshProUGUI'
    public TextMeshProUGUI scoreTXT; 

    float score;

    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Logika lompat dengan Input System Baru
        if (Mouse.current != null && Mouse.current.leftButton.wasPressedThisFrame)
        {
            Rb.linearVelocity = Vector2.up * jumpForce;
        }

        // Memperbarui tulisan skor di layar setiap frame
        scoreTXT.text = "POINT : " + score;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Menambah skor jika melewati pipa (menyentuh objek dengan tag "point")
        if(collision.gameObject.tag == "point")
        {
            score++;
        }
        if(collision.gameObject.tag == "pipa")
        {
            Destroy(gameObject);
        }
    }
}