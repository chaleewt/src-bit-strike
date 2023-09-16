using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoverEvent : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] AudioClip tabSound;

    public void OnPointerEnter(PointerEventData eventData)
    {
        AudioSource audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.PlayOneShot(tabSound);
    }

    public void OnPointerExit(PointerEventData eventData)
    {

    }
}
