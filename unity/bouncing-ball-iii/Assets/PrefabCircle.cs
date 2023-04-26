using UnityEngine;

public class PrefabCircle : MonoBehaviour
{
    public GameObject circle;
    
    void Start()
    {
        for (int i = 0; i < 20; i++)
        {
            Instantiate(circle, new Vector3(0, 0, 0), Quaternion.identity);
        }
    }
}
