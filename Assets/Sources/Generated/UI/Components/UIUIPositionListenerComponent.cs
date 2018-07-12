//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class UIEntity {

    public UIPositionListenerComponent uIPositionListener { get { return (UIPositionListenerComponent)GetComponent(UIComponentsLookup.UIPositionListener); } }
    public bool hasUIPositionListener { get { return HasComponent(UIComponentsLookup.UIPositionListener); } }

    public void AddUIPositionListener(System.Collections.Generic.List<IUIPositionListener> newValue) {
        var index = UIComponentsLookup.UIPositionListener;
        var component = CreateComponent<UIPositionListenerComponent>(index);
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceUIPositionListener(System.Collections.Generic.List<IUIPositionListener> newValue) {
        var index = UIComponentsLookup.UIPositionListener;
        var component = CreateComponent<UIPositionListenerComponent>(index);
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveUIPositionListener() {
        RemoveComponent(UIComponentsLookup.UIPositionListener);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class UIMatcher {

    static Entitas.IMatcher<UIEntity> _matcherUIPositionListener;

    public static Entitas.IMatcher<UIEntity> UIPositionListener {
        get {
            if (_matcherUIPositionListener == null) {
                var matcher = (Entitas.Matcher<UIEntity>)Entitas.Matcher<UIEntity>.AllOf(UIComponentsLookup.UIPositionListener);
                matcher.componentNames = UIComponentsLookup.componentNames;
                _matcherUIPositionListener = matcher;
            }

            return _matcherUIPositionListener;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class UIEntity {

    public void AddUIPositionListener(IUIPositionListener value) {
        var listeners = hasUIPositionListener
            ? uIPositionListener.value
            : new System.Collections.Generic.List<IUIPositionListener>();
        listeners.Add(value);
        ReplaceUIPositionListener(listeners);
    }

    public void RemoveUIPositionListener(IUIPositionListener value, bool removeComponentWhenEmpty = true) {
        var listeners = uIPositionListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveUIPositionListener();
        } else {
            ReplaceUIPositionListener(listeners);
        }
    }
}
