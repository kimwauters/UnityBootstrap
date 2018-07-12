//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class UIEntity {

    public UIActiveListenerComponent uIActiveListener { get { return (UIActiveListenerComponent)GetComponent(UIComponentsLookup.UIActiveListener); } }
    public bool hasUIActiveListener { get { return HasComponent(UIComponentsLookup.UIActiveListener); } }

    public void AddUIActiveListener(System.Collections.Generic.List<IUIActiveListener> newValue) {
        var index = UIComponentsLookup.UIActiveListener;
        var component = CreateComponent<UIActiveListenerComponent>(index);
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceUIActiveListener(System.Collections.Generic.List<IUIActiveListener> newValue) {
        var index = UIComponentsLookup.UIActiveListener;
        var component = CreateComponent<UIActiveListenerComponent>(index);
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveUIActiveListener() {
        RemoveComponent(UIComponentsLookup.UIActiveListener);
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

    static Entitas.IMatcher<UIEntity> _matcherUIActiveListener;

    public static Entitas.IMatcher<UIEntity> UIActiveListener {
        get {
            if (_matcherUIActiveListener == null) {
                var matcher = (Entitas.Matcher<UIEntity>)Entitas.Matcher<UIEntity>.AllOf(UIComponentsLookup.UIActiveListener);
                matcher.componentNames = UIComponentsLookup.componentNames;
                _matcherUIActiveListener = matcher;
            }

            return _matcherUIActiveListener;
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

    public void AddUIActiveListener(IUIActiveListener value) {
        var listeners = hasUIActiveListener
            ? uIActiveListener.value
            : new System.Collections.Generic.List<IUIActiveListener>();
        listeners.Add(value);
        ReplaceUIActiveListener(listeners);
    }

    public void RemoveUIActiveListener(IUIActiveListener value, bool removeComponentWhenEmpty = true) {
        var listeners = uIActiveListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveUIActiveListener();
        } else {
            ReplaceUIActiveListener(listeners);
        }
    }
}