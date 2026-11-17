using Unity.VisualScripting;
using UnityEngine;

public class TreeOfBirds : MonoBehaviour
{
    [SerializeField] private Bird[] _sparrows;
    [SerializeField] private float _interactionDistance;

    [SerializeField] private Transform _playerTransform;

    private void Update()
    {
        for (int i = 0; i < _sparrows.Length; i++)
        {
            Bird sparrow = _sparrows[i];

            if (Vector3.Distance(sparrow.transform.position, _playerTransform.position) <= _interactionDistance)
            {
                sparrow.gameObject.SetActive(true);
            }
        }
    }

} 
// Step 1: write the TreeOfBirds class in this file!
