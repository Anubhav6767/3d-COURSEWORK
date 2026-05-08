using UnityEngine;

public class TrashObject : MonoBehaviour
{
    [TextArea(3, 6)]
    public string environmentalFact = "Littering harms wildlife!";

    public float spinSpeed = 45f;

    void Update()
    {
        transform.Rotate(0, spinSpeed * Time.deltaTime, 0);
    }
}