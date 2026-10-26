using UnityEngine;
using UnityEngine.UI;

public class SwitchImages : MonoBehaviour
{
    [SerializeField] public bool isglass = true;
    [SerializeField] private Texture glassTrue;
    [SerializeField] private Texture glassFalse;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SwitchImage();
    }

    public void SwitchImage()
{
    if (isglass == true)
    {
        GetComponent<RawImage>().texture = glassTrue;
    }
    else if (isglass == false)
    {
        GetComponent<RawImage>().texture = glassFalse;
    }
}
}
