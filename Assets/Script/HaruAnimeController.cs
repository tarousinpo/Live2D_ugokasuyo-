using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Live2D.Cubism.Framework.Motion;
using Live2D.Cubism.Framework.Expression;

public class HaruAnimeController : MonoBehaviour
{

    // 表情
    // 0 = 驚き
    // 1 = ふつう
    // 2 = 笑顔
    // 3 = じとめ
    // 4 = てれる
    // 5 = いかり
    // 6 = かなしみ
    // 7 =　冷めた普通
    CubismExpressionController _expressionController;
    CubismMotionController _motionController;

    // Start is called before the first frame update
    void Start()
    {
         _motionController = GetComponent<CubismMotionController>();
         _expressionController = GetComponent<CubismExpressionController>();
    }



    public void HaruchangAmazingAnime(AnimationClip clip){
        _expressionController.CurrentExpressionIndex = 0;
        Debug.Log(clip);
        _motionController.PlayAnimation(clip, isLoop: false);
    }

    public void HaruchangNormalAnime(AnimationClip clip){
        _expressionController.CurrentExpressionIndex = 1;
        _motionController.PlayAnimation(clip, isLoop: false);
    }

    public void HaruchangSmileAnime(AnimationClip clip){
        _expressionController.CurrentExpressionIndex = 2;
        _motionController.PlayAnimation(clip, isLoop: false);
    }

    public void HaruchangZitoAnime(AnimationClip clip){
        _expressionController.CurrentExpressionIndex = 3;
        _motionController.PlayAnimation(clip, isLoop: false);
    }

    public void HaruchangTereAnime(AnimationClip clip){
        _expressionController.CurrentExpressionIndex = 4;
        _motionController.PlayAnimation(clip, isLoop: false);
    }
    public void HaruchangAngryAnime(AnimationClip clip){
        _expressionController.CurrentExpressionIndex = 5;
        _motionController.PlayAnimation(clip, isLoop: false);
    }    
    public void HaruchangSadAnime(AnimationClip clip){
        _expressionController.CurrentExpressionIndex = 6;
        _motionController.PlayAnimation(clip, isLoop: false);
    }
}
