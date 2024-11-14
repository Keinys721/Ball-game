using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed = 10f; // Greičio kintamasis, valdo judėjimo greitį
    private Rigidbody rb; // Rigidbody komponentas

    // Start funkcija kviečiama kartą, kai scenos objektas yra aktyvuojamas
    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Gauname Rigidbody komponentą
    }

    // FixedUpdate naudojamas fizikos skaičiavimams
    void FixedUpdate()
    {
        // Gauname įvestį iš klaviatūros (strėlytės arba WASD klavišai)
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Sudarome jėgos vektorių
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // Pridedame jėgą, kad rutulys riedėtų
        rb.AddForce(movement * speed);
    }
}
