using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float jumpForce = 7f; // Jėga, su kuria objektas šoka
    public float groundDistance = 0.6f; // Atstumas iki žemės
    public LayerMask groundMask; // Sluoksnis, kuris laikomas žeme
    private Rigidbody rb; // Rigidbody komponentas
    
    private bool isGrounded; // Tikrina, ar žaidėjas yra ant žemės

    void Start()
    {
        // Gaukime Rigidbody komponentą
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Tikriname, ar objektas yra ant žemės naudojant Raycast
        isGrounded = Physics.Raycast(transform.position, Vector3.down, groundDistance, groundMask);

        // Jei paspaudžiamas "Jump" ir objektas yra ant žemės, tada šokama
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            Jump();
        }
    }

    // Funkcija, atsakinga už šuolį
    void Jump()
    {
        // Pridedame momentinę jėgą šuoliui aukštyn
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}
