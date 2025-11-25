using UnityEngine;
using UnityEngine.Playables;

public class events : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    private bool stayOff = false;
    public GameObject lightsOutButton;
    public PlayableDirector lightsOut;
    public GameObject lightThatGoesOut;
    public GameObject doorSwingButton;
    public PlayableDirector doorSwing;
    public GameObject button;
    public PlayableDirector play;
    // Update is called once per frame
    void Update()
    {
        if (stayOff == true)
        {
            lightThatGoesOut.gameObject.SetActive(false);
        }
        else
        {
            lightThatGoesOut.gameObject.SetActive(true);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("lightsOff"))
        {
            lightsOut.Play();
            lightsOutButton.gameObject.SetActive(false);
            stayOff = true;
        }
        if (other.gameObject.CompareTag("DoorSwing"))
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
