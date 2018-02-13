using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class WebController : MonoBehaviour
{
    public string url = "https://store.dolcegabbana.com/it/uomo/abbigliamento/abiti/abito-in-tela-di-lana-stretch-nero-G15SCTFUBBGN0000.html?cgid=men-apparel-suits#start=4";

    public void StartWebView()
    {
        StartCoroutine(ViewWebCO());
    }
    public IEnumerator ViewWebCO()
    {
        using (WWW www = new WWW(url))
        {
            yield return www;
            Renderer renderer = GetComponent<Renderer>();
            renderer.material.mainTexture = www.texture;
        }
    }
}
