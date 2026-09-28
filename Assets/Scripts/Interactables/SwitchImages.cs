using UnityEngine;
using UnityEngine.UI;

public class SwitchImages : MonoBehaviour
{
    [SerializeField] private bool isglass = true;
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
    if (isglass)
    {
        GetComponent<RawImage>().texture = glassTrue;
    }
    else
    {
        GetComponent<RawImage>().texture = glassFalse;
    }
}
}
