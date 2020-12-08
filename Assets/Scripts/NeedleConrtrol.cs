using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI.ProceduralImage;
using DG.Tweening;

public class NeedleConrtrol : MonoBehaviour
{
    [SerializeField] private ProceduralImage _proceduralImage;

    private void MoveNeedle()
    {
        //bouge l'aiguille de 0 à 0.5 trois fois
        //si l'aiguille à fait 3 allé retour
        //on lance l'animation de calque et donne un coef force à la claque
        _proceduralImage.fillAmount = Mathf.Clamp(_proceduralImage.fillAmount, 0f , 0.5f);
        Sequence sequence = DOTween.Sequence();
        //sequence.Append(_proceduralImage.fillAmount);
    }

    private void OnClick()
    {
        //si on clic sur l'écran
        //alors on arrête l'aiguille
        //on lance l'anim claque ou on resite à la claque et donne un coef force à la claque
    }

    private float _needleValue;
}
