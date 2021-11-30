using Unity.UIWidgets.engine;
using Unity.UIWidgets.widgets;
using Unity.UIWidgets.material;

public class UIWidgetRL : UIWidgetsPanel
{
    protected void OnEnable()
    {
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
                    child: new Home()
                )
            );
        }
    }

    class Home : StatelessWidget
    {
        public override Widget build(BuildContext context)
        {
            return UIWidgetsHotReload.GetHero(context);
        }
    }
}