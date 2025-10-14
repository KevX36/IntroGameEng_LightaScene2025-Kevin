using UnityEngine;

public class lightsOff : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public GameObject LOBT; //stands for lights out block trigger
    public GameObject turnoff;
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("lightsOff"))
        {
            Destroy(turnoff);
            turnoff.gameObject.SetActive(false);
            Destroy(turnoff);
        }
        

        
    }
}
