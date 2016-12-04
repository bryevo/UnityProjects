using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_controller : MonoBehaviour
{
    public float speed;
    public Text countText;
    private new Rigidbody rigidbody;
    private int count;
    public GameObject item;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rigidbody.AddForce(movement * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("item_Pickup"))
        {
            other.gameObject.SetActive(false);
            count++;
            SetCountText();
            if (count == item.transform.childCount)
                countText.text = "You win!";
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
    }
}
