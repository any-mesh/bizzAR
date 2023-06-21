using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openURL : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void github()
    {
        Application.OpenURL("https://github.com/any-mesh");
    }
    public void twitter()
    {
        Application.OpenURL("https://twitter.com/ani_mesh101");
    }
    public void linkedin()
    {
        Application.OpenURL("https://www.linkedin.com/in/animesh-kumar-singh-7a5497257/");
    }
}
