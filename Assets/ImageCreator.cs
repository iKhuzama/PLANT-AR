using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ImageCreator : MonoBehaviour
{

    [SerializeField] private GameObject imageCreator;
    [SerializeField] private Vector3 imageOffset;

    private GameObject butterfly;
    private ARTrackedImageManager arTracker;


    private void OnEnable()
    {
        arTracker = gameObject.GetComponent<ARTrackedImageManager>();
        arTracker.trackedImagesChanged += OnImageChabged;
    }

    private void OnImageChabged(ARTrackedImagesChangedEventArgs obj)
    {

foreach (ARTrackedImage image in obj.added)
        {
            butterfly = Instantiate(imageCreator, image.transform);
            butterfly.transform.position += imageOffset;
        }
    } 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
