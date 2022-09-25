using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamerControl : MonoBehaviour
{
    public Transform shotPosition;
    public GameObject shot;
    public GameObject bum;
    public Image image;
    private float lifevalue = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown (KeyCode.F)) {
            GameObject go = Instantiate (shot, shotPosition.position, shotPosition.rotation) as GameObject;
            GameObject gobum = Instantiate (bum, shotPosition.position, shotPosition.rotation) as GameObject;
            go.GetComponent<Rigidbody>().velocity = shotPosition.transform.forward*10f;
            Destroy (go.gameObject, 2f);
            Destroy (gobum.gameObject, 2f);
        }
       
    }
     private void OnCollisionEnter(Collision shotting){
        if(shotting.collider.gameObject.tag.Equals("zombi")){
            lifevalue -= 10f;
            float x = lifevalue /100f;
            image.fillAmount=x;
            image.color=Color.Lerp(Color.red,Color.green,x);
        
            
        }
     }
     private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag.Equals("heart")){
            lifevalue += 10f;
            float x = lifevalue /100f;
            image.fillAmount=x;
            image.color=Color.Lerp(Color.red,Color.green,x);
            


        }
     }
}
