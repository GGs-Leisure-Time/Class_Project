using UnityEngine;

public class Cube : Shapes
{
    private void Start()
    {
        print(gameObject+"體積" +GetVolume());
    }

}
