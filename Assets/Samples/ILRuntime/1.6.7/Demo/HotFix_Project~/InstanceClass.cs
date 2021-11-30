using uiwidgets;
using Unity.UIWidgets.gestures;
using Unity.UIWidgets.material;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.widgets;
using UnityEngine;

namespace HotFix_Project
{
    public class InstanceClass
    {
        public static Widget CreateContainerHero(BuildContext context, string heroId, GestureTapCallback onTap, float? width)
        {
            return new SizedBox(
                width: width,
                height: width,
                child: new Hero(
                    tag: heroId,
                    child: new Unity.UIWidgets.material.Material(
                        color: Colors.transparent,
                        child: new InkWell(
                            onTap: onTap,
                            child: new Container(color: Colors.purple)
                        )
                    )
                )
            );
        }

        public static Widget BuildWithContext(BuildContext context)
        {
            Debug.Log("creaing context");
            return new Scaffold(
                appBar: new AppBar(
                    title: new Text("Basic Hero Animation")
                ),
                body: new Center(
                    child: CreateContainerHero(
                        context,
                        heroId: "hero1",
                        width: 200.0f,
                        onTap: () =>
                        {
                            Debug.Log($"this is in on tap, {context}");
                            Navigator.of(context).push(new MaterialPageRoute(
                                    builder: (BuildContext contextx) =>
                                    {
                                        Debug.Log("this is in builder");
                                        return new Scaffold(
                                            appBar: new AppBar(
                                                title: new Text("Flippers Page")
                                            ),
                                            body: new Container(
                                                color: Colors.lightBlueAccent,
                                                padding: EdgeInsets.all(16.0f),
                                                alignment: Alignment.topLeft,
                                                child: CreateContainerHero(
                                                    contextx,
                                                    heroId: "hero1",
                                                    width: 100.0f,
                                                    onTap: () =>
                                                    {
                                                        Debug.Log("this is in hero click");

                                                        Navigator.of(contextx).pop<object>();
                                                    }
                                                )
                                            )
                                        );
                                    }
                                )
                            );
                        }
                    )
                )
            );
        }
    }
}