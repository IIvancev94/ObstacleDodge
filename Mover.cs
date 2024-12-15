using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;

    //[SerializeField] float xValue = 0.00f;
    //[SerializeField] float yValue = 0.00f;
    //[SerializeField] float zValue = 0.00f;
    void Start()
    {
        PrintInstruction();
    }

    void Update()
    {
        OnMove();
    }

    void PrintInstruction()
    {
        Debug.Log("Dobro dosao u igricu!");
        Debug.Log("Kreci se pomocu WASD i Arrow");
        Debug.Log("Ne udaraj u objekte!");
    }

    private void OnMove()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, yValue, zValue);
    }
}
