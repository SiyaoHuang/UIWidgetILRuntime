using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UIWidgets.engine;
using Unity.UIWidgets.widgets;
using uiwidgets;
using Unity.UIWidgets.material;

public class UIWidgetRL : UIWidgetsPanel
{
    protected void OnEnable()
    {
        // if you want to use your own font or font icons.
        // AddFont("Material Icons", new List<string> {"MaterialIcons-Regular.ttf"}, new List<int> {0});
        base.OnEnable();
    }

    protected override void main()
    {
        ui_.runApp(new MyApp());
    }

    class MyApp : StatelessWidget
    {
        public override Widget build(BuildContext context)
        {
            return new MaterialApp(
                home: new Center(
                //child: HelloWorld.GetWidget()
                child: new Home()
            )
                );
        }
    }

    class Home: StatelessWidget
    {
        public override Widget build(BuildContext context)
        {
            return HelloWorld.GetHero(context);
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
