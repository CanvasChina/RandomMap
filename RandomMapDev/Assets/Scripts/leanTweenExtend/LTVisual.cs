using UnityEngine;
using System.Collections;

public class LTVisual : MonoBehaviour {

	public LTVEnum ltvEnum;

	public AnimationCurve animCurve;

	public LeanTweenType leanTweenType = LeanTweenType.easeInExpo;

	public float toValue = 1;

	public float toTime = 0.5f;

	public Vector3 toVecValue = Vector3.one;

	public System.Action callComplate = null;

	public bool isOnStart = true;

	// Use this for initialization
	void Start () {

		if(isOnStart)
			DoTween();
	
	}

	public void DoTween() {
	
		LTDescr tween = null;

		switch(ltvEnum) {

		case LTVEnum.moveX:
			LeanTween.moveLocalX(this.gameObject, toValue, toTime).setEase(leanTweenType).setOnComplete(OnComplete);
			break;
		case LTVEnum.anim_moveX:
			tween = LeanTween.moveLocalX(this.gameObject, toValue, toTime);
			tween.setEase(LeanTweenType.animationCurve);
			tween.animationCurve = animCurve;
			tween.setOnComplete(OnComplete);
			break;
		case LTVEnum.alpha:
			Color color = Color.white;
			color.a = toValue;
			RectTransform rectTran = (RectTransform)this.transform;
			LeanTween.color(rectTran, color, toTime).setEase(leanTweenType).setOnComplete(OnComplete);
			break;
		case LTVEnum.scale:
			LeanTween.scale(this.gameObject, toVecValue, toTime).setEase(leanTweenType).setOnComplete(OnComplete);
			break;
		case LTVEnum.anim_scale:
			tween = LeanTween.scale(this.gameObject, toVecValue, toTime);
			tween.animationCurve = animCurve;
			tween.setEase(LeanTweenType.animationCurve);
			tween.setOnComplete(OnComplete);
			break;
		default:
			break;

		}
	
	}

	public void OnComplete() {
	
		if(callComplate != null) {
		
			callComplate();
		
		}
	
	}

}