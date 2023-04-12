using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bg : MonoBehaviour
{//bu script dosyası nesneyi belirlediğimiz saniye 0 ra ulaşunca siler 
    public float timeToDestroy = 5f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyGameObject", timeToDestroy);
    }

    // Update is called once per frame
    void Update()
    {
    
    }
    void DestroyGameObject()
    {
        Destroy(gameObject);
    }
}
