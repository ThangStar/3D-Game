using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class JerryOnTrigger : MonoBehaviour
{
    [SerializeField]
    public GameObject thang_talk;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "thang")
        {
            thang_talk.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "thang")
        {
            print("Thang exit");
            thang_talk.SetActive(false);
        }
    }
}
