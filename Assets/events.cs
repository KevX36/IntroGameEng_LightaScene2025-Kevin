using UnityEngine;
using UnityEngine.Playables;

public class events : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public GameObject lightsOutButton;
    public PlayableDirector lightsOut;
    public GameObject doorSwingButton;
    public PlayableDirector doorSwing;
    public GameObject button;
    public PlayableDirector play;
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(""))
        {
            lightsOut.Play();
            lightsOutButton.gameObject.SetActive(false);
        }
        if (other.gameObject.CompareTag(""))
        {
            doorSwing.Play();
            doorSwingButton.gameObject.SetActive(false);
        }
        if (other.gameObject.CompareTag(""))
        {
            play.Play();
            button.SetActive(false);
        }
    }
}
