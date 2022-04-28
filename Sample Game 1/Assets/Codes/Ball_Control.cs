using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;
using TMPro;

public class Ball_Control : MonoBehaviour
{
    Rigidbody Physics;
    public int speed;
    int counter = 0;
    public TextMeshProUGUI Counter_Text;
    public TextMeshProUGUI Game_Finished_Text;
   
    void Start()
    {
        Physics = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 vec3 = new Vector3(horizontal, 0, vertical);
        Physics.AddForce(vec3*speed);

        //Debug.Log("horizontal" + horizontal+" vertical"+ vertical);
    }
   
    private void OnTriggerEnter(Collider other)//OnTriggerEnter-OnTriggerExit-OnTriggerStay
    {
        // if(other.gameObject.tag=="Collectable_item_tag")
        // Destroy(other.gameObject);

        if (other.gameObject.tag == "Collectable_item_tag")
            other.gameObject.SetActive(false);
        counter++;
        Debug.Log("Point=" + counter);

        Counter_Text.text ="Point=" + counter.ToString();

        if (counter == 9)
            Game_Finished_Text.text = "Game Finished";
    }
}
